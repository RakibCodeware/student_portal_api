using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblSession
{
    public int SessionId { get; set; }

    public string SessionName { get; set; } = null!;

    public DateTime StartMonth { get; set; }

    public DateTime EndMonth { get; set; }

    public string? Details { get; set; }
}
