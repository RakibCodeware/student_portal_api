using EduPortalAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EduPortalAPI.Models
{
    public class StudentInformation
    {
        public long StudentID { get; set; }
        public long RollNo { get; set; }    
        public string StudentName { get; set; }
        public long GroupID { get; set; }
        public short ClassID { get; set; }
        public short ClsGrpID { get; set; }
        public long SectionID { get; set; }
        public int BatchID { get; set; }
        public long ClsSecID { get; set; }
        public string ClsName { get; set; }
        public string SECTIONNAME { get; set;}
    }
       


    }

