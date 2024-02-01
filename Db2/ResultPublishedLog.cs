using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ResultPublishedLog
{
    public int Sl { get; set; }

    public int? ExInSl { get; set; }

    public DateTime? ActionTime { get; set; }

    public bool? IsPublished { get; set; }
}
