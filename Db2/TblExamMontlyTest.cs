using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblExamMontlyTest
{
    public int MonthlyTestId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public string? ExInId { get; set; }

    public double? Patternmarks { get; set; }

    public double? Passmarks { get; set; }
}
