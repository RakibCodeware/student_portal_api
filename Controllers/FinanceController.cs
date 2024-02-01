using EduPortalAPI.Data;
using EduPortalAPI.Db2;
using EduPortalAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EduPortalAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public FinanceController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("payments")]
        public IActionResult  paymentInfos(long StudentId)
        {
            try {

                using (var dbContext = new VirtualDbContext2())
                {
                    var result = (from pay in dbContext.PaymentInfos
                                  join ct in dbContext.FeesCategoryInfos on pay.FeeCatId equals ct.FeeCatId
                                  join b in dbContext.BatchInfos on pay.BatchId equals b.BatchId
                                  where pay.PaidAmount!=null && pay.CreatedAt!=null && pay.IsPaid == true && pay.StudentId == StudentId 
                                  orderby pay.CreatedAt descending
                                  select new Models.PaymentInfo
                                  {
                                      StudentId = (int)pay.StudentId,

                                      BatchName = b.BatchName,
                                      FeeCategory = ct.FeeCatName,
                                      OrderNo = pay.OrderNo,
                                      PaidAmount = (float)pay.PaidAmount,
                                      PaymentDate = (DateTime)pay.CreatedAt,


                                  }).ToList();
                    return Ok(result);
                }   
            } 
            catch(Exception ex) { return BadRequest("Something went wrong!"); }
           
        }


        [HttpGet]
        [Route("invoice")]
        public IActionResult invoice(string OrderNo)
        {
            using (var dbContext = new VirtualDbContext2())
            {
                var result = (from pay in dbContext.PaymentInfos
                              join ct in dbContext.FeesCategoryInfos on pay.FeeCatId equals ct.FeeCatId into feeCatJoin
                              from ct in feeCatJoin.DefaultIfEmpty()
                              join b in dbContext.BatchInfos on pay.BatchId equals b.BatchId into batchJoin
                              from b in batchJoin.DefaultIfEmpty()
                              where pay.IsPaid == true && pay.OrderNo == OrderNo
                              select new Models.PaymentInfo
                              {
                                  StudentId = (int)pay.StudentId,
                                  BatchName = b.BatchName,
                                  FeeCategory = ct.FeeCatName,
                                  OrderNo = pay.OrderNo,
                                  PaidAmount = (float)pay.PaidAmount,
                                  PaymentDate = (DateTime)pay.CreatedAt,

                              }).FirstOrDefault();

                return Ok(result);
            }
   
        }

    }
}
