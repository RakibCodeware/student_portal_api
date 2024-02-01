using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class DailyAttendanceRecord
{
    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public long? Eid { get; set; }

    public short? BatchId { get; set; }

    public short? ShiftId { get; set; }

    public short? ClsSecId { get; set; }

    public short? ClsGrpId { get; set; }

    public DateTime? AttDate { get; set; }

    public string? InHur { get; set; }

    public string? InMin { get; set; }

    public string? InSec { get; set; }

    public string? OutHur { get; set; }

    public string? OutMin { get; set; }

    public string? OutSec { get; set; }

    public string? AttStatus { get; set; }

    public string? StateStatus { get; set; }

    public string? AttManual { get; set; }

    public string? DailyStartTimeAltCloseTime { get; set; }

    /// <summary>
    /// This field for just staff departmetn id .That is null for every student
    /// </summary>
    public short? Did { get; set; }

    public short? DesId { get; set; }
}
