using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDailyEmployeeAttendanceRecord
{
    public long? Eid { get; set; }

    public long? EcardNo { get; set; }

    public string? Ename { get; set; }

    public string? Egender { get; set; }

    public string? LoginTime { get; set; }

    public string? LogoutTime { get; set; }

    public DateTime? AttDates { get; set; }

    public string? AttStatus { get; set; }

    public string? AttManual { get; set; }

    public string? AttMonth { get; set; }

    public string? InHur { get; set; }

    public string? InMin { get; set; }

    public string? OutHur { get; set; }

    public string? OutMin { get; set; }

    public short? Did { get; set; }

    public DateTime? AttDate { get; set; }

    public int? Code { get; set; }

    public short? DesId { get; set; }

    public string? DesName { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public bool? IsFaculty { get; set; }

    public DateTime? EjoiningDate { get; set; }

    public bool? Dstatus { get; set; }

    public bool? IsTeacher { get; set; }

    public string? Dname { get; set; }
}
