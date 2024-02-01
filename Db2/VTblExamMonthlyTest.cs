using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VTblExamMonthlyTest
{
    public int MonthlyTestId { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public int? BatchId { get; set; }

    public string BatchName { get; set; } = null!;

    public short? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public short? ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public string? ExInId { get; set; }

    public DateTime? ExStartDate { get; set; }

    public DateTime? ExEndDate { get; set; }

    public string? ExName { get; set; }

    public double? Patternmarks { get; set; }

    public double? Passmarks { get; set; }

    public long? StudentId { get; set; }

    public string? FullName { get; set; }

    public long? RollNo { get; set; }

    public double? Obtainmarks { get; set; }
}
