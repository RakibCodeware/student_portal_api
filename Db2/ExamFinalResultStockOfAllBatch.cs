using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamFinalResultStockOfAllBatch
{
    public long Sl { get; set; }

    public long? StudentId { get; set; }

    public string? ExInId { get; set; }

    public int? BatchId { get; set; }

    public short? ShiftId { get; set; }

    public short? ClsSecId { get; set; }

    public short? ClsGrpId { get; set; }

    public double? FinalGpaOfExamWithOptionalSub { get; set; }

    public string? FinalGradeOfExamWithOptionalSub { get; set; }

    public double? FinalTotalMarksOfExamWithOptionalSub { get; set; }

    public double? FinalGpaOfExam { get; set; }

    public string? FinalGradOfExam { get; set; }

    public double? FinalTotalMarksOfExam { get; set; }

    public DateTime? PublishDate { get; set; }

    public bool? IsFinalExam { get; set; }
}
