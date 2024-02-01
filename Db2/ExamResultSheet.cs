using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamResultSheet
{
    public long Sl { get; set; }

    public string? ExInId { get; set; }

    public long ExamId { get; set; }

    public int StudentId { get; set; }

    public int? RollNo { get; set; }

    public double? Gpa { get; set; }

    public string? Grade { get; set; }

    public double? WithoutOpGpa { get; set; }

    public string? WithoutOpGrade { get; set; }

    public double? TotalMarks { get; set; }

    public double? WithoutOpTotalMarks { get; set; }

    public bool? IsPassed { get; set; }

    public string? FailSubjectCode { get; set; }

    public string? AbsentSubjectCode { get; set; }

    public string? FailAbsentSubjectCode { get; set; }

    public int? NumberOfFailSubject { get; set; }

    public int? NumberOfAbsentSubject { get; set; }

    public int? NumberOfFailSubjectTotal { get; set; }

    public int? BatchId { get; set; }

    public int? ShiftId { get; set; }

    public int? ClsGrpId { get; set; }

    public int? ClsSecId { get; set; }

    public virtual ExamInfo? ExIn { get; set; }
}
