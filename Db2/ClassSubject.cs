using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ClassSubject
{
    public long Csid { get; set; }

    public short? ClassId { get; set; }

    public long? SubId { get; set; }

    public int? CourseId { get; set; }

    public double? Marks { get; set; }

    public string? SubCode { get; set; }

    public short? Ordering { get; set; }

    public bool? IsOptional { get; set; }

    public short? GroupId { get; set; }

    public bool? BothType { get; set; }

    public bool? IsCommon { get; set; }

    public long? RelatedSubId { get; set; }

    public virtual Class? Class { get; set; }
}
