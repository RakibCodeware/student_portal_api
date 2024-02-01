using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VCheckStudentFine
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

    public DateTime? DateOfStart { get; set; }

    public DateTime? DateOfEnd { get; set; }

    public bool? IsActive { get; set; }

    public string? FeeCatName { get; set; }

    public double? FeeFine { get; set; }
}
