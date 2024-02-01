using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VStudentAbsentDetail
{
    public int? BatchId { get; set; }

    public long? StudentId { get; set; }

    public DateTime? AbsentDate { get; set; }

    public double? AbsentFine { get; set; }

    public DateTime? PayDate { get; set; }

    public bool? IsPaid { get; set; }

    public string? FullName { get; set; }

    public short? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public string BatchName { get; set; } = null!;

    public short? ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public string? FinePurpose { get; set; }

    public long? RollNo { get; set; }
}
