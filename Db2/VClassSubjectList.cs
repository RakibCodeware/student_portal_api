using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VClassSubjectList
{
    public long Csid { get; set; }

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public long? SubId { get; set; }

    public string? SubName { get; set; }

    public string? CourseName { get; set; }

    public short? GroupId { get; set; }

    public short? Ordering { get; set; }

    public int? CourseId { get; set; }

    public bool? IsOptional { get; set; }

    public bool? BothType { get; set; }

    public bool? IsCommon { get; set; }

    public string? SubCode { get; set; }
}
