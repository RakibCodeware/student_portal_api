using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VUserAccountDetail
{
    public long UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool? Status { get; set; }

    public long? UserTypeId { get; set; }

    public bool? IsActive { get; set; }

    public string UserType { get; set; } = null!;
}
