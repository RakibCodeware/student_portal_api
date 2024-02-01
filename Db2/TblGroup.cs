using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblGroup
{
    public short GroupId { get; set; }

    public string? GroupName { get; set; }

    public virtual ICollection<TblClassGroup> TblClassGroups { get; } = new List<TblClassGroup>();
}
