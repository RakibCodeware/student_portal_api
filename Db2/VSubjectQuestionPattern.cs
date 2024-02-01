using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VSubjectQuestionPattern
{
    public long SubId { get; set; }

    public int SubQpid { get; set; }

    public string? SubName { get; set; }

    public string? Qpname { get; set; }

    public double? Qmarks { get; set; }

    public long Qpid { get; set; }

    public double? PassMarks { get; set; }

    public double? ConvertTo { get; set; }

    public short ExId { get; set; }

    public string? ExName { get; set; }

    public short? BatchId { get; set; }

    public string BatchName { get; set; } = null!;

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public int? CourseId { get; set; }

    public string? CourseName { get; set; }

    public bool? IsOptional { get; set; }

    public short? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public short? Ordering { get; set; }

    public double? SubQpmarks { get; set; }

    public long? Expr1 { get; set; }
}
