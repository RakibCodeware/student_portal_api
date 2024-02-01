using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VGuideTeacher
{
    public long StudentId { get; set; }

    public string? FullName { get; set; }

    public string? Gender { get; set; }

    public string? Mobile { get; set; }

    public long? RollNo { get; set; }

    public bool? GuideStatus { get; set; }

    public long? Eid { get; set; }

    public string? Ename { get; set; }

    public string? TcodeNo { get; set; }

    public string? Egender { get; set; }

    public bool? IsFaculty { get; set; }

    public short? ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public short? ConfigId { get; set; }

    public int? BatchId { get; set; }

    public string? DesName { get; set; }

    public string BatchName { get; set; } = null!;

    public string? ShiftName { get; set; }

    public string? GroupName { get; set; }

    public string? SectionName { get; set; }

    public bool? Dstatus { get; set; }

    public bool? IsTeacher { get; set; }

    public string? Dname { get; set; }

    public short? Did { get; set; }
}
