using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VFeesCatDetail
{
    public int? FeeCatId { get; set; }

    public string? FeeCatName { get; set; }

    public string? Pname { get; set; }

    public double? Amount { get; set; }

    public int CatPid { get; set; }

    public short Pid { get; set; }

    public string? BatchName { get; set; }

    public int? BatchId { get; set; }

    public double? FeeFine { get; set; }

    public double? FeeAmount { get; set; }

    public int? StdTypeId { get; set; }

    public string? StdTypeName { get; set; }

    public string? StoreNameKey { get; set; }
}
