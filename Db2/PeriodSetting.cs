using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PeriodSetting
{
    public int PeriodId { get; set; }

    public string? PeriodName { get; set; }

    public TimeSpan? PeriodStartTime { get; set; }

    public TimeSpan? PeriodEndTime { get; set; }
}
