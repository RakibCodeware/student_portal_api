using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentStore
{
    public string StoreNameKey { get; set; } = null!;

    public string? StoreTitle { get; set; }

    public int? Ordering { get; set; }

    public bool? IsActive { get; set; }
}
