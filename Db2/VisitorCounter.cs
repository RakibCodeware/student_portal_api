using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VisitorCounter
{
    public int Sl { get; set; }

    public long? HitNumber { get; set; }

    public DateTime? LastUpdate { get; set; }
}
