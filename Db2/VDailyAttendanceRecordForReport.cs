using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDailyAttendanceRecordForReport
{
    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public DateTime? AttDate { get; set; }

    public string? InHur { get; set; }

    public string? InMin { get; set; }

    public string? OutHur { get; set; }

    public string? OutMin { get; set; }

    public string? AttStatus { get; set; }

    public string? StateStatus { get; set; }

    public string? AttManual { get; set; }

    public string? DailyStartTimeAltCloseTime { get; set; }

    public short? BatchId { get; set; }

    public short? ShiftId { get; set; }

    public short? ClsGrpId { get; set; }

    public int? Code { get; set; }

    public string? FullName { get; set; }

    public short? ClsSecId { get; set; }

    public string BatchName { get; set; } = null!;

    public string? ShiftName { get; set; }

    public string? GroupName { get; set; }

    public string? SectionName { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public long? AdmissionNo { get; set; }

    public string? FathersMobile { get; set; }

    public string? MothersMoible { get; set; }
}
