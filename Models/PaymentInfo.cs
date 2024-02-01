namespace EduPortalAPI.Models
{
    public class PaymentInfo
    {
        public int StudentId { get; set; }
        public string BatchName { get; set; }
        public string FeeCategory { get; set; }
        public float PaidAmount { get; set; }
        public string OrderNo { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
