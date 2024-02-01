using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblAdmParticularsCategory
{
    public int AdmCatPid { get; set; }

    public int? AdmFeeCatId { get; set; }

    public short? Pid { get; set; }

    public double? Amount { get; set; }

    public virtual TblAdmFeesCategory? AdmFeeCat { get; set; }

    public virtual ParticularsInfo? PidNavigation { get; set; }
}
