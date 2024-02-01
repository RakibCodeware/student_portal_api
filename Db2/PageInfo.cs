using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PageInfo
{
    public int PageNameId { get; set; }

    public string PageName { get; set; } = null!;

    public string PageTitle { get; set; } = null!;

    public string? ModuleType { get; set; }

    public bool? Chosen { get; set; }

    public short? UserTypeId { get; set; }

    public virtual ICollection<UserTypePageInfo> UserTypePageInfos { get; } = new List<UserTypePageInfo>();
}
