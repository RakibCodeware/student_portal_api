using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VThanaDetail
{
    public short? DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public string? ThanaName { get; set; }

    public int ThanaId { get; set; }

    public string? DistrictNameBn { get; set; }

    public string? ThanaNameBn { get; set; }
}
