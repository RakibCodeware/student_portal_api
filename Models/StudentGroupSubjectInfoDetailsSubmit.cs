using System.ComponentModel.DataAnnotations;

namespace EduPortalAPI.Models
{
    public class StudentGroupSubjectInfoDetailsSubmit
    {


        public long StudentId { get; set; }
        public List<int> MandatorySubjects { get; set; }
        public int OptionalSubject { get; set; }
    }
}
