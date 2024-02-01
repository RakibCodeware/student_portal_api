using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentInfoDetail
{
    public long Sl { get; set; }

    public long? OrderId { get; set; }

    public string? Particular { get; set; }

    public double? ParticularAmount { get; set; }

    public bool? Status { get; set; }

    public string? OrderNo { get; set; }

    public virtual PaymentInfo? Order { get; set; }
}
