using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PostOffice
{
    public int PostOfficeId { get; set; }

    public int? ThanaId { get; set; }

    public short? DistrictId { get; set; }

    public string? PostOfficeName { get; set; }

    public string? PostOfficeNameBn { get; set; }
}
