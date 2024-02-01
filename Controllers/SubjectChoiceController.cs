using EduPortalAPI.Data;
using EduPortalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Authorization;
using static System.Collections.Specialized.BitVector32;
using EduPortalAPI.Db2;
using Microsoft.Extensions.Configuration;

namespace EduPortalAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubjectChoiceController : ControllerBase
    {
     
        private readonly DataContext _dataContext;


        public SubjectChoiceController(DataContext dataContext)
        {
        
            _dataContext = dataContext;
        }


        [HttpGet]
        [Route("MandetorySubjects")]
        public async Task<IActionResult> GetMandetorySubjects(long StudentId)
        {

            StudentInformation studentInformation = getStudentInfo(StudentId);
            try
            {
                int ClassId = studentInformation.ClassID;
                int GroupId = (int)studentInformation.GroupID;

                using (var dbContext = new VirtualDbContext2())
                {
                     var manSubjects=await dbContext.ClassSubjects
                     .Join(dbContext.NewSubjects,
                         cs => cs.SubId,
                         ns => ns.SubId,
                         (cs, ns) => new { cs, ns })
                     .Where(joined => joined.cs.ClassId == ClassId &&
                                      joined.cs.GroupId == GroupId &&
                                      (joined.cs.IsOptional == false || joined.cs.BothType == true))
                     .Select(joined => new SubjectChoice
                     {
                         SubjeceId = (short)joined.cs.SubId,
                         SubjectName = joined.ns.SubName + "(" + joined.cs.SubCode + ")",
                         MustTaken = joined.cs.IsOptional == false && joined.cs.BothType == false
                     })
     .ToListAsync();

                    return Ok(manSubjects);

                }
            }
            catch (Exception ex)
            {

                return BadRequest("Something went wrong!");
            }

        }

        [HttpGet]
        [Route("OptionalSubject")]
        public async Task<IActionResult> GetOptionalSub(long StudentId)
        {
            StudentInformation studentInformation = getStudentInfo(StudentId);
            try
            {
                int ClassId = studentInformation.ClassID;
                int GroupId = (int)studentInformation.GroupID;

                using(var _context=new VirtualDbContext2()) 
                {
                    var subjectlist = await _context.ClassSubjects
                         .Join(_context.NewSubjects,
                             cs => cs.SubId,
                             ns => ns.SubId,
                             (cs, ns) => new { cs, ns })
                         .Where(joined => joined.cs.ClassId == ClassId &&
                                          joined.cs.GroupId == GroupId &&
                                          (joined.cs.IsOptional == true || joined.cs.BothType == true))
                         .Select(joined => new SubjectChoice
                         {
                             SubjeceId = (short)joined.cs.SubId,
                             SubjectName = joined.ns.SubName + "(" + joined.cs.SubCode + ")",
                             MustTaken = joined.cs.IsOptional == true && joined.cs.BothType == false
                         })
         .ToListAsync();

                    return Ok(subjectlist);

                }
               
            }
            catch (Exception ex)
            {
               return BadRequest("Something went wrong!");
            }

        }

        [HttpGet]
        [Route("Subjects")]
        public async Task<IActionResult> GetSubjects(long StudentId)
        {
            
            try
            {
            StudentInformation studentInformation = getStudentInfo(StudentId);
                if (studentInformation == null)
                    return BadRequest("Student not found!");

                List<Subject> subjects = new List<Subject>();
                // Temporary Off
                subjects =await getSubjectsApproved(studentInformation.StudentID, studentInformation.BatchID);
                if (subjects != null && subjects.Count>0)
                    return Ok(new { subjectStatus = "Approved", Subjects = subjects });

                subjects = new List<Subject>();
                subjects = await getSubjectsPending(studentInformation.StudentID, studentInformation.BatchID);
                if (subjects != null && subjects.Count>0)
                    return Ok(new { subjectStatus = "Pending", Subjects = subjects });

                return Ok(new { });

            }
            catch (Exception ex)
            {

                //   return BadRequest("Something went wrong!");
                return BadRequest("Something went wrong!");
            }

        }


        [HttpPost]
        [Route("Submit")]
        public async Task<IActionResult> SaveData(StudentGroupSubjectInfoDetailsSubmit _values)
        {
            try
            {                     

                if (_values.MandatorySubjects.Count != 3)
                    return BadRequest("You are required to choose three mandatory subjects.");
                if (_values.OptionalSubject==0)
                    return BadRequest("You are required to choose a optional subjects.");
                if (_values.MandatorySubjects.Contains(_values.OptionalSubject))
                {
                    return BadRequest("It's impossible to consider a subject as optional and mandatory simultaneously.");
                }

                StudentInformation studentInformation = getStudentInfo(_values.StudentId);
                if (studentInformation == null)
                    return BadRequest("Student not found!");

                List<Subject> subjects = new List<Subject>();
                //Temporary Off
                subjects =await getSubjectsApproved(studentInformation.StudentID, studentInformation.BatchID);
                if (subjects != null && subjects.Count > 0)
                    return Ok(new { message = "You have previously submitted the elective subjects choice. If you wish to make changes to the current selection, kindly reach out to the administration for further assistance.", preElectiveSubjects = subjects });

                subjects = new List<Subject>();
                subjects = await getSubjectsPending(studentInformation.StudentID, studentInformation.BatchID);
                if (subjects != null && subjects.Count > 0)
                    return Ok(new { message = "You have previously submitted the elective subjects choice. If you wish to make changes to the current selection, kindly reach out to the administration for further assistance.", preElectiveSubjects = subjects });

                var info = new StudentGroupSubjectInfo()
                {
                    StudentId = _values.StudentId,//unique
                    ClassID = studentInformation.ClassID,
                    ClsGrpID = studentInformation.ClsGrpID,
                    BatchID = studentInformation.BatchID,//unique id
                    Subjects = new List<StudentGroupSubjectDetails>()

                };

                foreach (int _subid in _values.MandatorySubjects)
                {
                    info.Subjects.Add(new StudentGroupSubjectDetails { SubId = _subid, MSStatus = true });
                }
                info.Subjects.Add(new StudentGroupSubjectDetails { SubId = _values.OptionalSubject, MSStatus = false });

                _dataContext.StudentGroupSubjectInfoTemp.Add(info);
                await _dataContext.SaveChangesAsync();
                return Ok("Successfully Submitted.");

            }
            catch (Exception ex)
            {

               // return BadRequest("Something went wrong!");
                return BadRequest("Something went wrong!");
            }

        }




        //get student information using student ID
        private StudentInformation getStudentInfo(long studentId)
        {
            using(var context = new VirtualDbContext2()) 
            {
                var studentInformationList = (from currentStudent in context.CurrentStudentInfos
                                              join classSection in context.TblClassSections on currentStudent.ClsSecId equals classSection.ClsSecId
                                              join classGroup in context.TblClassGroups on currentStudent.ClsGrpId equals classGroup.ClsGrpId into grp
                                              from groupData in grp.DefaultIfEmpty()
                                              join batchInfo in context.BatchInfos on currentStudent.BatchId equals batchInfo.BatchId into batch
                                              from batchData in batch.DefaultIfEmpty()
                                              join section in context.Sections on classSection.SectionId equals section.SectionId into sec
                                              from sectionData in sec.DefaultIfEmpty()
                                              join groupInfo in context.TblGroups on groupData.GroupId equals groupInfo.GroupId into groupInfoData
                                              from groupInfoDataResult in groupInfoData.DefaultIfEmpty()
                                              where currentStudent.StudentId == studentId
                                              select new StudentInformation
                                              {
                                                  StudentID = currentStudent.StudentId,
                                                  RollNo = (long)currentStudent.RollNo,
                                                  StudentName = currentStudent.FullName,
                                                  ClassID = (short)currentStudent.ClassId,
                                                  ClsGrpID = (short)(groupData != null ? groupData.ClsGrpId : 0),
                                                  SectionID = (long)(sectionData != null ? sectionData.SectionId : 0),
                                                  BatchID = (int)(batchData != null ? batchData.BatchId : 0),
                                                  ClsSecID = (int)currentStudent.ClsSecId,
                                                  ClsName = currentStudent.ClassName,
                                                  SECTIONNAME = sectionData != null ? sectionData.SectionName : "",
                                                  GroupID = (int)(groupInfoDataResult != null ? groupInfoDataResult.GroupId : 0)
                                              }).FirstOrDefault();

                return studentInformationList;


            }


        }

        //get Approved Subject using student id and batch id
        private async Task<List<Subject>> getSubjectsApproved(long StudentId, int BatchId)
        {
            try
            {
                using (var dbContext=new VirtualDbContext2()) 
                {
                    var result = await (
                     from sgs in dbContext.StudentGroupSubSetups
                     join sgssd in dbContext.StudentGroupSubSetupDetails on sgs.SgsubId equals sgssd.SgsubId
                     join csi in dbContext.CurrentStudentInfos on new { StudentId = (long)sgs.StudentId, BatchId = sgs.BatchId } equals new { StudentId = csi.StudentId, BatchId = csi.BatchId }
                     join ns in dbContext.NewSubjects on sgssd.SubId equals (int)ns.SubId
                     join cs in dbContext.ClassSubjects on new { ClassID = csi.ClassId, SubId = (int)sgssd.SubId } equals new { ClassID = cs.ClassId, SubId = (int)cs.SubId }
                     where sgs.StudentId == StudentId && sgs.BatchId == BatchId
                     orderby sgssd.Msstatus descending, sgssd.SubId
                         select new Subject
                         {
                             SubId = (int)sgssd.SubId,
                             SubjectName = ns.SubName + "(" + cs.SubCode + ")",
                             IsMandatory=(bool)sgssd.Msstatus
                         }).ToListAsync();

                    return result;
                }

                
            }
            catch (Exception ex)
            {
                return null;

             }
           


        }

        //get subject pending information student ID
        private async Task<List<Subject>> getSubjectsPending(long StudentId, int BatchId)
        {
            try
            {
                using (var _dbContext = new VirtualDbContext2())

                {
                    var stdGroupSubject = await _dbContext.StudentGroupSubjectInfoTemps
                        .FirstOrDefaultAsync(sgs => sgs.StudentId == StudentId && sgs.BatchId == BatchId);

                    if (stdGroupSubject != null)
                    {
                        var subjects = await (from sd in _dbContext.StudentGroupSubjectDetailsTemps
                                              join s in _dbContext.NewSubjects on sd.SubId equals s.SubId
                                              where sd.SgsId == stdGroupSubject.SgsId
                                              select new Subject
                                              {
                                                  SubId = (int)sd.SubId,
                                                  SubjectName = s.SubName,
                                                  IsMandatory = sd.Msstatus
                                              }).ToListAsync();

                        return subjects;

                    }
                   
                }
            }
            catch (Exception ex)
            {

               
            }

            return null;

        }

 

    }

}



