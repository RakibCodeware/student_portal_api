using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserTypePageInfo
{
    public long UserTypePageId { get; set; }

    public long UserTypeId { get; set; }

    public int? PageNameId { get; set; }

    public int MenuId { get; set; }

    public bool? ViewAction { get; set; }

    public bool? SaveAction { get; set; }

    public bool? UpdateAction { get; set; }

    public bool? DeleteAction { get; set; }

    public bool? GenerateAction { get; set; }

    public virtual PageInfo? PageName { get; set; }

    public virtual UserTypeInfo UserType { get; set; } = null!;
}
