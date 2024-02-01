using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ClassXiimarksSheetTotalResultProcess
{
    public long Sl { get; set; }

    public string? ExInId { get; set; }

    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public int? BatchId { get; set; }

    public short? ClsSecId { get; set; }

    public short? ShiftId { get; set; }

    public long? SubId { get; set; }

    public bool? IsOptional { get; set; }

    public int? CourseId { get; set; }

    public long? Qpid { get; set; }

    public double? Marks { get; set; }

    public short? ClsGrpId { get; set; }

    public double? MarksOfAllPatternByScid { get; set; }

    public string? GradeOfAllPatternByScid { get; set; }

    public double? PointOfAllPatternByScid { get; set; }

    public double? MarksOfSubjectWithAllDependencySub { get; set; }

    public string? GradeOfSubjectWithAllDependencySub { get; set; }

    public double? PointOfSubjectWithAllDependencySub { get; set; }

    public virtual BatchInfo? Batch { get; set; }

    public virtual TblClassSection? ClsSec { get; set; }

    public virtual ExamInfo? ExIn { get; set; }

    public virtual QuestionPattern? Qp { get; set; }

    public virtual ShiftConfiguration? Shift { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }

    public virtual NewSubject? Sub { get; set; }
}
