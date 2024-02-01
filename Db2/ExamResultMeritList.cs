using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamResultMeritList
{
    public long? ResultId { get; set; }

    public int? BatchId { get; set; }

    public int? ExamId { get; set; }

    public int? BatchRank { get; set; }

    public int? ShiftId { get; set; }

    public int? ShiftRank { get; set; }

    public int? ClsGrpId { get; set; }

    public int? GrpRank { get; set; }

    public int? ClsSecId { get; set; }

    public int? SecRank { get; set; }
}
