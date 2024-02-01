using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentInfo
{
    public long? StudentId { get; set; }

    public int? BatchId { get; set; }

    public int? FeeCatId { get; set; }

    public long OrderId { get; set; }

    public string? OrderNo { get; set; }

    public double? Amount { get; set; }

    public double? Discount { get; set; }

    public double? OnlineCharge { get; set; }

    public double? OnlineChargePer { get; set; }

    public double? TotalAmount { get; set; }

    public bool? IsPaid { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? OrderSl { get; set; }

    public string? Response { get; set; }

    public string? PaymentRefId { get; set; }

    public double? PaidAmount { get; set; }

    public string? ClientMobileNo { get; set; }

    public DateTime? OrderDateTime { get; set; }

    public DateTime? IssuerPaymentDateTime { get; set; }

    public string? IssuerPaymentRefNo { get; set; }

    public string? Status { get; set; }

    public string? StatusCode { get; set; }

    public string? ServiceType { get; set; }

    public string? MissingFields { get; set; }

    public string? PaymentType { get; set; }

    public int? AdmissionFormNo { get; set; }

    public string? PaymentMedia { get; set; }

    public string? Note { get; set; }

    public int? OpenStudentId { get; set; }

    public string? StoreNameKey { get; set; }

    public string? UpdateStoreNameKey { get; set; }

    public virtual ICollection<PaymentInfoDetail> PaymentInfoDetails { get; } = new List<PaymentInfoDetail>();
}
