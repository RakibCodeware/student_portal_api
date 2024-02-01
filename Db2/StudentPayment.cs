using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentPayment
{
    public int StudentPaymentId { get; set; }

    public long? StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public long? RollNo { get; set; }

    public int? FeeCatId { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public bool? PayStatus { get; set; }

    public double? AmountPaid { get; set; }

    public double? FineAmount { get; set; }

    public bool? DiscountStatus { get; set; }

    public double? DiscountTk { get; set; }

    public double? GrandTotal { get; set; }

    public double? DueAmount { get; set; }

    public int? StdTypeId { get; set; }

    public string? OthersParticular { get; set; }

    public double? OthersAmount { get; set; }

    public double? PreDueAmount { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
