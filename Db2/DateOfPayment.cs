using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class DateOfPayment
{
    public int DateOfPaymentId { get; set; }

    public int? FeeCatId { get; set; }

    public DateTime? DateOfStart { get; set; }

    public DateTime? DateOfEnd { get; set; }

    public bool? IsActive { get; set; }

    public virtual FeesCategoryInfo? FeeCat { get; set; }
}
