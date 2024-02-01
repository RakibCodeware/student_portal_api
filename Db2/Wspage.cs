using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Wspage
{
    public string PageId { get; set; } = null!;

    public string? Page { get; set; }

    public bool? Status { get; set; }

    public int? Ordering { get; set; }
}
