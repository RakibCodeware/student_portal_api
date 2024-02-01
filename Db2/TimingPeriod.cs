using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TimingPeriod
{
    public string Period { get; set; } = null!;

    public int? Ordering { get; set; }
}
