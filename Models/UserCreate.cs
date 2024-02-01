using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EduPortalAPI.Models
{
    public class UserCreate
    {        
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public string SecurityKey { get; set; }
    }
}
