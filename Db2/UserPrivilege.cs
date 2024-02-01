using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserPrivilege
{
    public long UserId { get; set; }

    public int PageNameId { get; set; }

    public int MenuId { get; set; }

    public bool? ViewAction { get; set; }

    public bool? SaveAction { get; set; }

    public bool? UpdateAction { get; set; }

    public bool? DeleteAction { get; set; }

    public bool? GenerateAction { get; set; }

    public virtual UserAccount User { get; set; } = null!;
}
