using System.ComponentModel.DataAnnotations;

namespace EduPortalAPI.Models
{
    public class StudentGroupSubjectDetails
    {
        [Key]
        public long Id { get; set; }       
        public long SubId { get; set; }
        public bool MSStatus { get; set; }
        public StudentGroupSubjectInfo StudentGroupSubjectInfo { get; set; }
        public long SgsId { get; set; } //Foreign key 
    }
}
