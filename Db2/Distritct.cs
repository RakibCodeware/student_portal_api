using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Distritct
{
    public short DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public string? DistrictNameBn { get; set; }

    public virtual ICollection<Thana> Thanas { get; } = new List<Thana>();
}
