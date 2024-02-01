namespace EduPortalAPI.Models
{
    public class UserChangePassword
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }       
        public int UpdatedBy { get; set; }
    }
}
