using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AllowanceLog
{
    public long Alid { get; set; }

    public short? Aid { get; set; }

    public decimal? AlnewPercentage { get; set; }

    public decimal? AloldPercentage { get; set; }

    public DateTime? Aldate { get; set; }

    public int? AlchangedBy { get; set; }
}
