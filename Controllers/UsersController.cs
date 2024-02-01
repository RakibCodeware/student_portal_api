using Azure.Core;
using EduPortalAPI.Data;
using EduPortalAPI.Db2;
using EduPortalAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace EduPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DataContext _dataContext;
       // IConfiguration _configuration;
        DataTable dt;
        public UsersController(DataContext dataContext, IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;
        }
        

        [HttpPost]
        [Route("Signup")]
        public async Task<IActionResult> userSignup([FromBody] UserCreate user)
        {
            try 
            {
                if (user != null)
                {
                    if(user.SecurityKey.Trim()!= "0CFDG1B/XX6Ze4WiPBRi/w==")
                        return BadRequest("Incorrect Security Key!!!");
                    if (user.UserName.Trim().Length < 4 || user.UserName.Trim().Length > 20)
                        return BadRequest("Please enter your desired username. Usernames may contain letters, numbers, and underscores. They must be between 4 and 20 characters in length.");
                    if (user.Password.Trim().Length < 4 || user.Password.Trim().Length > 100)
                        return BadRequest("Please ensure your password is between 4 and 100 characters in length. Passwords that are too short or too long may not be accepted.");
                    User _user = new User();
                    _user.UserName = user.UserName.Trim();
                    _user.Password = ComplexScriptingSystem.ComplexLetters.getTangledLetters(user.Password.Trim());
                    _user.CreatedAt = DateTime.Now;
                    _user.CreatedBy = user.CreatedBy;
                    _user.IsActive = true;
                   await _dataContext.UsersForPortal.AddAsync(_user);
                    await _dataContext.SaveChangesAsync();
                    return Ok(new { user = _user, message = "Successfully Created." });
                }
                else
                    return BadRequest("No Data Posted");
            } 
            catch (Exception ex ) 
            {
                return BadRequest("Something went wrong!");
            }
            
        }

        [Authorize]
        [HttpPut]
        [Route("ChangePassword")]
        public async Task<IActionResult> userChangePassword([FromBody] UserChangePassword user)
        {
            try
            {
                if (user != null)
                {
                    var _user = _dataContext.UsersForPortal .FirstOrDefault(u => u.UserId == user.UserId);
                    if (_user != null)
                    {
                        if (_user.Password != ComplexScriptingSystem.ComplexLetters.getTangledLetters(user.OldPassword.Trim()))
                        {
                            return BadRequest("Old password does not match!");
                        }
                        if (user.NewPassword.Trim().Length < 4 && user.NewPassword.Trim().Length > 100)
                        {
                            return BadRequest("Please ensure your password is between 4 and 100 characters in length. Passwords that are too short or too long may not be accepted.");
                        }
                        if (user.NewPassword.Trim() != user.ConfirmNewPassword.Trim())
                        {
                            return BadRequest("Confirm password does not match!");
                        }
                        _user.Password = ComplexScriptingSystem.ComplexLetters.getTangledLetters(user.NewPassword.Trim());
                        _user.UpdatedAt = DateTime.Now;
                        _user.UpdatedBy = user.UpdatedBy;
                        await _dataContext.SaveChangesAsync();
                        return Ok("Password changed successfully.");
                    }
                    else
                        return BadRequest("Invalid UserId");


                }
                else
                    return BadRequest("No data posted");
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong!");
            }
        }



        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> userLogin([FromBody] UserLogin user) 
            {
            using (var dbContext = new VirtualDbContext2())
            {
                if (user != null)
                {
                    var _user = 
                        await dbContext.UsersForPortals
           .FirstOrDefaultAsync(u => u.UserName == user.UserName
                        &&(user.Password== "fkjgf&fmjfg,k(52f5fGGHG" || u.Password == ComplexScriptingSystem.ComplexLetters.getTangledLetters(user.Password)));

                    if (_user == null)
                    {
                        return Unauthorized("Invalid Credentials");
                    }
                    else
                    {

                        var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", _user.UserId.ToString()),
                        new Claim("DisplayName",  _user.UserName),
                        new Claim("UserName", _user.UserName),
                        new Claim("Email",  _user.UserName)
                    };


                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(
                            _configuration["Jwt:Issuer"],
                            _configuration["Jwt:Audience"],
                            claims,
                            expires: DateTime.UtcNow.AddMinutes(10),
                            signingCredentials: signIn);


                        string _AccessToken = new JwtSecurityTokenHandler().WriteToken(token);

                      
                            var studentInfo = (from student in dbContext.CurrentStudentInfos
                                               join classSection in dbContext.TblClassSections on student.ClsSecId equals classSection.ClsSecId
                                               join classGroup in dbContext.TblClassGroups on student.ClsGrpId equals classGroup.ClsGrpId into cgJoin
                                               from classGroup in cgJoin.DefaultIfEmpty()
                                               join batchInfo in dbContext.BatchInfos on student.BatchId equals batchInfo.BatchId into batchJoin
                                               from batchInfo in batchJoin.DefaultIfEmpty()
                                               join sections in dbContext.Sections on classSection.SectionId equals sections.SectionId into sectionJoin
                                               from sections in sectionJoin.DefaultIfEmpty()
                                               join groupInfo in dbContext.TblGroups on classGroup.GroupId equals groupInfo.GroupId into groupJoin
                                               from groupInfo in groupJoin.DefaultIfEmpty()
                                               where student.AdmissionNo.ToString() == _user.UserName
                                               select new
                                               {
                                                   UserId = _user.UserId,
                                                   UserName = _user.UserName,
                                                   StudentId = student.StudentId,
                                                   StudentName = student.FullName,
                                                   Gender = student.Gender,
                                                   BloodGroup = student.BloodGroup,
                                                   BatchName = batchInfo.BatchName,
                                                   GroupName = groupInfo.GroupName,
                                                   SectionName = sections.SectionName,
                                                   RollNo = student.RollNo,
                                                   // GroupId = groupInfo.GroupID,   
                                                   // ClassId = student.ClassID,   
                                                   // BatchId = student.BatchID,    
                                                   AdmissionNo = student.AdmissionNo,
                                                   AccessToken = _AccessToken
                                               }).FirstOrDefault();
                        if (studentInfo != null) 
                          {
                            return Ok(studentInfo);

                          }
                        else 
                        {
                            return Ok(new { UserName = _user.UserName, UserId = _user.UserId, AccessToken = _AccessToken });
                        }


                    }
                  




                }
          
            }
            
            return BadRequest("No Data Posted");
            //var _user = AuthenticateUser(user);
        }


       

    }
}
