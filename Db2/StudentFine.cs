using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentFine
{
    public long FineId { get; set; }

    public long? StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public short? RollNo { get; set; }

    public string? FinePurpose { get; set; }

    public double? Fineamount { get; set; }

    public double? Discount { get; set; }

    public double? FineamountPaid { get; set; }

    public DateTime? PayDate { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
