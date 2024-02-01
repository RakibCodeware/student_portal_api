using EduPortalAPI.Data;
using EduPortalAPI.Db2;
using EduPortalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Data;

namespace EduPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMemoryCache _cache;

        public ResultController(IConfiguration configuration, IMemoryCache memoryCache)
        {
            _configuration = configuration;
            _cache = memoryCache;
        }

        [HttpGet]
        [Route("reuslt")]
       
      public async Task<IActionResult>getData(string BatchId,string ExamId,string studentId)
        {
            try
            {
                // if data found the cache then exicute this statement
                if (_cache.TryGetValue($"ExamNames_{BatchId}_{ExamId}_{studentId}", out List<Result> cachedResult))
                {

                    return Ok(cachedResult);
                }
                //if data not found in the cache then again retrive data
                SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("CwProttoyConnection").ToString());

                string sql = @"with ss as  (
                            select 0 as StudentId,SubId,1 as MSStatus,Ordering from ClassSubject  where ClassID in(select ClassID from BatchInfo where BatchId='"+ BatchId + @"') and IsCommon=1 and IsOptional=0 union all

                            SELECT StudentId, SubId,MSStatus,Ordering FROM v_StudentGroupSubSetup WHERE   BatchId="+ BatchId + @")
                           , ms as(select distinct  m.ExId,m.ExInId,m.StudentId,m.RollNo,m.ClsSecId,m.SubId,m.CourseId,m.SubQPId,m.Marks,m.ConvertToPercentage,m.ConvertMarks,m.ClsGrpId,m.IsPassed,m.TotalConvertMarksOfSub,m.ExamId,m.Batchid,m.ShiftId from  Class_ElevenMarksSheet m inner join ss on (m.StudentId=ss.StudentId or ss.StudentId=0) and ss.SubId=m.SubId and m.studentid='"+ studentId +@"'  and ExamID='"+ ExamId + @"'), Mxm as(select et.semesterexam,ms.BatchId, ms.StudentId,ms.RollNo,ms.ShiftId,ms.SubId,ms.CourseId, case when ms.IsPassed=1 then 0 else 1 end As IsFailed,qp.qpName, sqp.QpId,ms.marks ,sqp.QMarks from ms inner join ExamType et on ms.exid=et.exid inner join SubjectQuestionPattern sqp on ms.subqpid=sqp.subqpid inner join QuestionPattern qp on sqp.QPid=qp.QpId ), MxmFM as(SELECT  semesterexam, BatchId, StudentId,RollNo,ShiftId,SubId,CourseId, MCQ ,   CQ  ,Practical  FROM   Mxm PIVOT ( SUM(QMarks) FOR [qpName] IN ( MCQ,CQ,Practical)) AS P group by semesterexam, BatchId, StudentId,RollNo,ShiftId,SubId,CourseId,p.mcq,p.cq,p.Practical),MxmFM_T as(select BatchId,StudentId,RollNo,ShiftId,SubId, CourseId, sum(isnull(mcq,0)) MCQ,sum(isnull(cq,0)) CQF ,sum(isnull(Practical,0)) Practical from MxmFM group by semesterexam,BatchId,StudentId,RollNo,ShiftId,SubId, CourseId),Mxm1 as(SELECT  semesterexam, BatchId, StudentId,RollNo,ShiftId,SubId,CourseId, IsFailed, MCQ,   CQ,Practical FROM   Mxm PIVOT ( SUM(Marks) FOR [qpName] IN ( MCQ,CQ,Practical)) AS P group by semesterexam, BatchId,StudentId,RollNo,ShiftId,SubId,CourseId, IsFailed,p.mcq,p.cq,p.Practical ),Mxm1_T as(select BatchId,StudentId,RollNo,ShiftId,SubId, CourseId, sum(IsFailed) as IsFailed,case when CQ is null and  MCQ is null and Practical is null then 'AB' else '' end as AB,     sum(isnull(mcq,0)) MCQ,sum(isnull(cq,0)) CQ ,sum(isnull(Practical,0)) Practical from Mxm1 group by semesterexam,BatchId,StudentId,RollNo,ShiftId,SubId, CourseId, case when CQ is null and  MCQ is null and Practical is null then 'AB' else '' end),MaxN as(select subid,courseid,max(Cq) MaxCQ,max(mcq)MaxMCQ from  Mxm1_T  group by subid,courseid), psn as (select Mxm1_T.StudentId,Mxm1_T.ShiftId,csi.ClsSecId,csi.ClsGrpId, sum(round((Mxm1_T.cq+Mxm1_T.mcq+Mxm1_T.Practical),0)) TotalMark,ROW_NUMBER() OVER (order by  sum(round((Mxm1_T.cq+Mxm1_T.mcq+Mxm1_T.Practical),0)) desc) as PositionInGrp,ROW_NUMBER() OVER(PARTITION BY csi.ClsSecid order by   sum(round((Mxm1_T.cq+Mxm1_T.mcq+Mxm1_T.Practical),0)) desc) as PositionInSec   from  Mxm1_T inner join v_CurrentStudentInfo csi on Mxm1_T.batchid=csi.batchid and Mxm1_T.StudentId=csi.StudentId group by Mxm1_T.StudentId,Mxm1_T.ShiftId ,csi.ClsSecId,csi.ClsGrpId)  select '1' as IsIndependent, ClassName,Sxm2.batchid,Sxm2.studentid,Sxm2.rollno,Sxm2.subid,Sxm2.courseid,Sxm2.cq TotalCQ, Sxm2.mcq,Sxm2.Practical,(Sxm2.cq +Sxm2.mcq+Sxm2.Practical) TotalMark,MaxN.MaxCQ,MaxN.MaxMCQ,ns.SubName,acs.CourseName,cs.SubCode,cs.Marks,IsFailed,csi.FullName,csi.FathersName,csi.MothersName,csi.Session,convert(varchar(10), csi.DateOfBirth,105) as DateOfBirth,csi.ShiftName ,csi.GroupName,csi.SectionName,csi.RollNo,psn.PositionInSec,psn.PositionInGrp, case when gs.MSStatus is null then 1 else gs.MSStatus end as MSStatus,ers.IsPassed,ers.GPA,ers.Grade,ers.withoutOpGPA,ers.withoutOpGrade,AB   from Mxm1_T Sxm2  inner join NewSubject ns on Sxm2.subid=ns.subid inner join AddCourseWithSubject acs on Sxm2.subid=acs.subid and (Sxm2.courseid=acs.courseid or sxm2.courseid=0) inner join BatchInfo on sxm2.BatchId=BatchInfo.BatchId inner join ClassSubject cs on BatchInfo.ClassId=cs.ClassId and Sxm2.subid=cs.subid and Sxm2.courseid=cs.courseid inner join v_CurrentStudentInfo csi on Sxm2.batchid=csi.batchid and Sxm2.StudentId=csi.StudentId  inner join MaxN on Sxm2.subid=MaxN.subid and Sxm2.Courseid=MaxN.Courseid inner join psn on Sxm2.StudentId=psn.StudentId left join v_StudentGroupSubSetupDetails gs on Sxm2.Batchid=gs.Batchid and Sxm2.StudentId=gs.StudentId and Sxm2.Subid=gs.Subid left join Exam_ResultSheet ers on Sxm2.StudentId = ers.StudentID and ers.ExamID = '"+ ExamId + @"' order by MSStatus desc";
                DataTable dt = new DataTable();
                dt = CRUD.ReturnTableNull(sql, connection);

                List<Result> reuslts = new List<Result>();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string[] Grade = new string[2];
                            if (!dt.Rows[i]["AB"].ToString().Equals(""))
                            {
                                Grade[0] = "0";
                                Grade[1] = "AB";
                            }
                            else if (!dt.Rows[i]["IsFailed"].ToString().Equals("0"))
                            {
                                Grade[0] = "0";
                                Grade[1] = "F";
                            }
                            else
                            {
                                 Grade= markToGPA(int.Parse(dt.Rows[i]["TotalMark"].ToString()), int.Parse(dt.Rows[i]["Marks"].ToString())).Split('_');

                                reuslts.Add(new Result()
                                {
                                    Subcode = dt.Rows[i]["SubCode"].ToString(),
                                    StudentName = dt.Rows[i]["SubName"].ToString(),
                                    TotalCQ=dt.Rows[i]["TotalCQ"].ToString(),
                                    Practical= dt.Rows[i]["Practical"].ToString(),
                                    MCQ= dt.Rows[i]["mcq"].ToString(),
                                    ObtainedTotalMark = dt.Rows[i]["TotalMark"].ToString(),
                                    TotalMark = dt.Rows[i]["Marks"].ToString(),
                                    Grade = Grade[1]
                                });
                               
                            }
                            
                        }
                            
                       
                    }
                    if(reuslts.Count > 0)
                    {
                        _cache.Set($"ExamNames_{BatchId}_{ExamId}_{studentId}", reuslts, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(100)
                        });
                        return Ok(reuslts);
                    }
               
                }
                return NotFound("Result not found");

            }
            catch (Exception)
            {

                return Ok("Something wrong");
            }
          
        }

        [HttpGet]
        [Route("getExamName")]
        public async Task<IActionResult> GetExamName(int batchId, long studentId)
        {
            try
            {
                // if data found the cache then exicute this statement
                if (_cache.TryGetValue($"ExamNames_{batchId}_{studentId}", out List<ExamNameDto> cachedResult))
                {
                    
                    return Ok(cachedResult);
                }

                 //if data not found in the cache then again retrive data
                using (var dbContext = new VirtualDbContext2())
                {
                    var result = await (from examInfo in dbContext.VExamInfos
                                        where examInfo.BatchId == batchId 
                                        let groupName = examInfo.GroupName ?? ""
                                        let formattedExName = examInfo.ExName + (groupName.Length > 0 ? " (" + groupName + ")" : "")
                                        where dbContext.CurrentStudentInfos.Any(student => student.ClsGrpId == examInfo.ClsGrpId && student.StudentId == studentId)
                                        select new ExamNameDto
                                        {
                                            ExInSl = (int)examInfo.ExInSl,
                                            ExInId = examInfo.ExInId,
                                            ExName = formattedExName
                                        }).ToListAsync();

                    if (result.Count > 0)
                    {
                        // Store data into cache
                        _cache.Set($"ExamNames_{batchId}_{studentId}", result, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(100)
                        });
                        return Ok(result);
                    }

                    return NotFound("Data not Found");
                }
            }
            catch (Exception)
            {

                return Ok("Something Wrong");
            }
            
            
        }

        //Calculate Gap here
        private  string markToGPA(float Mark, float BaseMark)
        {
            Mark = (Mark / BaseMark) * 100;
            string result = "0_F";
            if (Mark >= 80)
                result = "5_A+";
            else if (Mark >= 70)
                result = "4_A";
            else if (Mark >= 60)
                result = "3.5_A-";
            else if (Mark >= 50)
                result = "3_B";
            else if (Mark >= 40)
                result = "2_C";
            else if (Mark >= 33)
                result = "1_D";
            return result;
        }

    }
}

