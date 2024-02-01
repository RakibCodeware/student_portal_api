using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VExamResutlSummary
{
    public int? BatchId { get; set; }

    public string? ClassName { get; set; }

    public int? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public long ExamId { get; set; }

    public string? ExamName { get; set; }

    public int? ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public int? TotalStudents { get; set; }

    public int? Passed { get; set; }

    public int? Failed { get; set; }

    public int? Gpa5 { get; set; }

    public int? Gpa4 { get; set; }

    public int? Gpa35 { get; set; }

    public int? Gpa3 { get; set; }

    public int? Gpa2 { get; set; }

    public int? Gpa1 { get; set; }

    public int? Fsub1 { get; set; }

    public int? Fsub2 { get; set; }

    public int? Fsub3 { get; set; }

    public int? Fsub31 { get; set; }
}
