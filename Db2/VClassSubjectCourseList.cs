using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VClassSubjectCourseList
{
    public long Csid { get; set; }

    public short? GroupId { get; set; }

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public short? ClassOrder { get; set; }

    public long SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int? SubOrder { get; set; }

    public int? CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? SubCode { get; set; }

    public double? Marks { get; set; }

    public short? Ordering { get; set; }

    public bool? IsOptional { get; set; }

    public int BatchId { get; set; }

    public string BatchName { get; set; } = null!;
}
