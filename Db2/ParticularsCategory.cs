using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ParticularsCategory
{
    public int CatPid { get; set; }

    public int? FeeCatId { get; set; }

    public short? Pid { get; set; }

    public double? Amount { get; set; }

    public int? StdTypeId { get; set; }

    public virtual FeesCategoryInfo? FeeCat { get; set; }

    public virtual ParticularsInfo? PidNavigation { get; set; }
}
