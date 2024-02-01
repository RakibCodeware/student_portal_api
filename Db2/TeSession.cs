using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeSession
{
    public int SessionId { get; set; }

    public string? Session { get; set; }

    public int? NumPatternId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual TeNumberPattern? NumPattern { get; set; }
}
