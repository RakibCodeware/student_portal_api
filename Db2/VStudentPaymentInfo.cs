using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VStudentPaymentInfo
{
    public int? FeeCatId { get; set; }

    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public bool? PayStatus { get; set; }

    public double? AmountPaid { get; set; }

    public double? FineAmount { get; set; }

    public bool? DiscountStatus { get; set; }

    public string? FeeCatName { get; set; }

    public string? FullName { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public int? BatchId { get; set; }

    public string? BatchName { get; set; }

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public short? ClsGrpId { get; set; }

    public string? SectionName { get; set; }

    public double? DiscountTk { get; set; }

    public short? ClsSecId { get; set; }

    public string? IdCard { get; set; }

    public int? StdTypeId { get; set; }

    public string? StdTypeName { get; set; }

    public double? DueAmount { get; set; }

    public double? FeeAmount { get; set; }

    public double? GrandTotal { get; set; }
}
