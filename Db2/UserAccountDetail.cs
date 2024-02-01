using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserAccountDetail
{
    public long UserDid { get; set; }

    public long UserId { get; set; }

    public long? UserTypeId { get; set; }

    public bool? IsActive { get; set; }

    public virtual UserAccount User { get; set; } = null!;

    public virtual UserTypeInfo? UserType { get; set; }
}
