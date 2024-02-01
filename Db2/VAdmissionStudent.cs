using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VAdmissionStudent
{
    public short Pid { get; set; }

    public string? Pname { get; set; }

    public int? AdmFeeCatId { get; set; }

    public double? Amount { get; set; }

    public string? FeeCatName { get; set; }

    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public double? FeeAmount { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public string? FullName { get; set; }

    public string? ClassName { get; set; }

    public string? SectionName { get; set; }

    public string? GroupName { get; set; }

    public string? ShiftName { get; set; }

    public double? AmountPaid { get; set; }

    public double? DueAmount { get; set; }

    public double? GrandTotal { get; set; }

    public double? DiscountTk { get; set; }

    public long? TransactionNo { get; set; }
}
