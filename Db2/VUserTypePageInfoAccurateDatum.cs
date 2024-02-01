using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VUserTypePageInfoAccurateDatum
{
    public long UserTypePageId { get; set; }

    public long UserTypeId { get; set; }

    public int PageNameId { get; set; }

    public string PageTitle { get; set; } = null!;

    public string? ModuleType { get; set; }

    public int MenuId { get; set; }

    public bool? ViewAction { get; set; }

    public bool? SaveAction { get; set; }

    public bool? UpdateAction { get; set; }

    public bool? DeleteAction { get; set; }

    public bool? GenerateAction { get; set; }
}
