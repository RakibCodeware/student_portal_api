using System.ComponentModel.DataAnnotations;

namespace EduPortalAPI.Models
{
    public class StudentGroupSubjectInfo
    {

        [Key]
        public long SgsId { get; set; } //Primary key 

        public long StudentId { get; set; } 
        public short ClassID { get; set; }
        public short ClsGrpID { get; set; }
        public int BatchID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ApprovedAt { get; set; }
        public long AprovedBy { get; set; }
        public List<StudentGroupSubjectDetails> Subjects {  get; set; } 
    }
}
