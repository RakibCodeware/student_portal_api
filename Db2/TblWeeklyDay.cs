using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblWeeklyDay
{
    public int WdayId { get; set; }

    public string DayName { get; set; } = null!;

    public string? ShortDayName { get; set; }

    public int OrderBy { get; set; }

    public bool Status { get; set; }
}
