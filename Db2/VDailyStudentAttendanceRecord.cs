using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDailyStudentAttendanceRecord
{
    public long? StudentId { get; set; }

    public string? LoginTime { get; set; }

    public string? LogoutTime { get; set; }

    public string? Shift { get; set; }

    public string? AttDate { get; set; }

    public string? AttStatus { get; set; }

    public string? AttManual { get; set; }

    public string? AttMonth { get; set; }

    public string? BatchName { get; set; }

    public string? FullName { get; set; }

    public string? Gender { get; set; }

    public long? AdmissionNo { get; set; }

    public string? InHur { get; set; }

    public string? InMin { get; set; }

    public string? OutHur { get; set; }

    public string? OutMin { get; set; }

    public long? RollNo { get; set; }

    public short? BatchId { get; set; }

    public short? ShiftId { get; set; }

    public short? ClsSecId { get; set; }

    public short? ClsGrpId { get; set; }

    public string? ClassName { get; set; }

    public short? ClassId { get; set; }

    public string? GroupName { get; set; }

    public int Ttl { get; set; }

    public int Pr { get; set; }

    public int Ab { get; set; }

    public int Lt { get; set; }

    public int Lv { get; set; }

    public string? SectionName { get; set; }
}
