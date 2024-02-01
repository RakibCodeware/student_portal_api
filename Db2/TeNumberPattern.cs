using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeNumberPattern
{
    public int NumPatternId { get; set; }

    public string? NumPattern { get; set; }

    public virtual ICollection<TeSession> TeSessions { get; } = new List<TeSession>();
}
