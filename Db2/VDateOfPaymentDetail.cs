using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDateOfPaymentDetail
{
    public int DateOfPaymentId { get; set; }

    public DateTime? DateOfStart { get; set; }

    public DateTime? DateOfEnd { get; set; }

    public string? FeeCatName { get; set; }

    public bool? IsActive { get; set; }

    public int FeeCatId { get; set; }

    public int? BatchId { get; set; }
}
