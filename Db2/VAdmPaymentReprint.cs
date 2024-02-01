using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VAdmPaymentReprint
{
    public long? RollNo { get; set; }

    public bool? PayStatus { get; set; }

    public string? FeeCatName { get; set; }

    public double? FeeAmount { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public string? ClassName { get; set; }

    public string? ShiftName { get; set; }

    public double? AmountPaid { get; set; }

    public long? StudentId { get; set; }

    public long? TransactionNo { get; set; }

    public string? FullName { get; set; }

    public string? Pname { get; set; }

    public double? Amount { get; set; }

    public int? BatchId { get; set; }

    public long? AdmissionNo { get; set; }

    public int AdmCatPid { get; set; }
}
