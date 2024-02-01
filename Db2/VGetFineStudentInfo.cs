using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VGetFineStudentInfo
{
    public string? FinePurpose { get; set; }

    public double? Fineamount { get; set; }

    public DateTime? PayDate { get; set; }

    public string? FullName { get; set; }

    public string? ShiftName { get; set; }

    public string BatchName { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? SectionName { get; set; }

    public double? FineamountPaid { get; set; }

    public long? StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public short? RollNo { get; set; }
}
