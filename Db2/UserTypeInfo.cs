using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserTypeInfo
{
    public long UserTypeId { get; set; }

    public string UserType { get; set; } = null!;

    public bool? IsActive { get; set; }

    public virtual ICollection<UserTypePageInfo> UserTypePageInfos { get; } = new List<UserTypePageInfo>();
}
