using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WseventInfoDetail
{
    public int Sl { get; set; }

    public int? Esl { get; set; }

    public string? Title { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public DateTime? EventDate { get; set; }

    public virtual WseventInfo? EslNavigation { get; set; }
}
