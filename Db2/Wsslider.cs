using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Wsslider
{
    public int Sl { get; set; }

    public string? Location { get; set; }

    public bool? Chosen { get; set; }

    public int? Ordering { get; set; }
}
