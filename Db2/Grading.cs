using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Grading
{
    public short Gid { get; set; }

    public string? Gname { get; set; }

    public double? GmarkMin { get; set; }

    public double? GmarkMax { get; set; }

    public double? GpointMin { get; set; }

    public double? GpointMax { get; set; }

    public string? Comment { get; set; }
}
