using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Excnote
{
    public int? Userid { get; set; }

    public DateTime? Attdate { get; set; }

    public string? Notes { get; set; }
}
