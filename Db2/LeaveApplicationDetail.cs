using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class LeaveApplicationDetail
{
    public long Sl { get; set; }

    public long Lacode { get; set; }

    public long Eid { get; set; }

    public DateTime? LeaveDate { get; set; }

    public bool? Used { get; set; }

    public virtual LeaveApplication LacodeNavigation { get; set; } = null!;
}
