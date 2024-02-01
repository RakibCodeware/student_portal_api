using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class NumRun
{
    public int NumRunid { get; set; }

    public int? Oldid { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public short? Cyle { get; set; }

    public short? Units { get; set; }
}
