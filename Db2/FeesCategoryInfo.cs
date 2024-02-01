using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class FeesCategoryInfo
{
    public int FeeCatId { get; set; }

    public int? BatchId { get; set; }

    public DateTime? DateOfCreation { get; set; }

    public double? FeeFine { get; set; }

    public double? FeeAmount { get; set; }

    public string? FeeCatName { get; set; }

    public long? ExInSl { get; set; }

    public bool? IsDemo { get; set; }

    public bool? IsDeleted { get; set; }

    public string? PaymentFor { get; set; }

    public short? ClsGrpId { get; set; }

    public string? StoreNameKey { get; set; }

    public virtual ICollection<ParticularsCategory> ParticularsCategories { get; } = new List<ParticularsCategory>();
}
