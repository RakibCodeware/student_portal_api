using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class OffdaySetting
{
    public int OffDateId { get; set; }

    public DateTime OffDate { get; set; }

    public string? Purpose { get; set; }

    public string? DayName { get; set; }

    public string? Month { get; set; }

    public int? OffDateYear { get; set; }

    public int? ShiftId { get; set; }
}
