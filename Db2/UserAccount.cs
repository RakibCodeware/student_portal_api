using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserAccount
{
    public long UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Status { get; set; }

    public long? UserTypeId { get; set; }

    public long? Eid { get; set; }

    public bool? IsAdviser { get; set; }

    public bool? IsEvaluator { get; set; }
}
