using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ParticularsInfo
{
    public short Pid { get; set; }

    public string? Pname { get; set; }

    public virtual ICollection<ParticularsCategory> ParticularsCategories { get; } = new List<ParticularsCategory>();

    public virtual ICollection<TblAdmParticularsCategory> TblAdmParticularsCategories { get; } = new List<TblAdmParticularsCategory>();
}
