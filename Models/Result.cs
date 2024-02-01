using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace EduPortalAPI.Models
{
    public class Result
    {
        public string Subcode {  get; set; }    

        public string StudentName { get; set;}
        public string Grade { get; set;}
        public string TotalCQ {  get; set;}
        public string Practical { get;set;}
        public string MCQ { get; set;}
        public string ObtainedTotalMark { get; set;}
        public string TotalMark { get; set;}


    }
}
