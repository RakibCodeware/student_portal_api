using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VStudentWiseSubjectList
{
    public short? ClassId { get; set; }

    public long? SubId { get; set; }

    public int? CourseId { get; set; }

    public string? SubName { get; set; }

    public string? SubCode { get; set; }

    public short? Ordering { get; set; }

    public bool? IsOptional { get; set; }

    public bool? BothType { get; set; }

    public bool? IsCommon { get; set; }

    public string? FullName { get; set; }

    public long? RollNo { get; set; }

    public short? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public short? ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public long StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public string? CourseName { get; set; }

    public string BatchName { get; set; } = null!;

    public string? ShiftName { get; set; }
}
