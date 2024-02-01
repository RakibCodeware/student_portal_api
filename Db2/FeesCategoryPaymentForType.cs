using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class FeesCategoryPaymentForType
{
    public string Id { get; set; } = null!;

    public string? PaymentFor { get; set; }

    public int? Ordering { get; set; }

    public bool? IsActive { get; set; }
}
