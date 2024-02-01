using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AllowanceType
{
    public short Aid { get; set; }

    public string? Atype { get; set; }

    public double? Apercentage { get; set; }

    public bool? Astatus { get; set; }
}
