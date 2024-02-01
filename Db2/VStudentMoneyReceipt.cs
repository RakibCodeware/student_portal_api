using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VStudentMoneyReceipt
{
    public short Pid { get; set; }

    public string? Pname { get; set; }

    public double? Amount { get; set; }

    public int? FeeCatId { get; set; }

    public double? FeeAmount { get; set; }

    public string? FeeCatName { get; set; }

    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public double? AmountPaid { get; set; }

    public double? DueAmount { get; set; }

    public double? GrandTotal { get; set; }

    public double? DiscountTk { get; set; }

    public double? FineAmount { get; set; }

    public string? FullName { get; set; }

    public string? ClassName { get; set; }

    public short? ClassOrder { get; set; }

    public string? GroupName { get; set; }

    public string? SectionName { get; set; }

    public string? ShiftName { get; set; }

    public long? TransactionNo { get; set; }

    public int? StdTypeId { get; set; }
}
