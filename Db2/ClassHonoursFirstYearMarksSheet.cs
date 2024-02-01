using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ClassHonoursFirstYearMarksSheet
{
    public long MarksSl { get; set; }

    public short? ExId { get; set; }

    public string? ExInId { get; set; }

    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public int? BatchId { get; set; }

    public short? ClsSecId { get; set; }

    public short? ShiftId { get; set; }

    public int? SubId { get; set; }

    public byte? CourseId { get; set; }

    public int? SubQpid { get; set; }

    public double? Marks { get; set; }

    public double? ConvertToPercentage { get; set; }

    public double? ConvertMarks { get; set; }

    public short? ClsGrpId { get; set; }

    public bool? IsPassed { get; set; }

    public double? TotalConvertMarksOfSub { get; set; }

    public virtual BatchInfo? Batch { get; set; }

    public virtual TblClassSection? ClsSec { get; set; }

    public virtual ExamType? Ex { get; set; }

    public virtual ExamInfo? ExIn { get; set; }

    public virtual ShiftConfiguration? Shift { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }

    public virtual SubjectQuestionPattern? SubQp { get; set; }
}
