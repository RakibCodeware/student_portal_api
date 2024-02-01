using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Workstation
{
    public int WorkstationId { get; set; }

    public string? WorkstationName { get; set; }

    public string? Ipaddress { get; set; }
}
