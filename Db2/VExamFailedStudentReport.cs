using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VExamFailedStudentReport
{
    public long ExamId { get; set; }

    public string? ExamName { get; set; }

    public int? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public int? ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public int StudentId { get; set; }

    public int? RollNo { get; set; }

    public string? FullName { get; set; }

    public int? NumberOfFailSubjectTotal { get; set; }

    public int? NumberOfAbsentSubject { get; set; }

    public string? SubName { get; set; }

    public string ClassName { get; set; } = null!;
}
