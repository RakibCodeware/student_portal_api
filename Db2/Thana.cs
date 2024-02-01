using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Thana
{
    public int ThanaId { get; set; }

    public short? DistrictId { get; set; }

    public string? ThanaName { get; set; }

    public string? ThanaNameBn { get; set; }

    public virtual Distritct? District { get; set; }
}
