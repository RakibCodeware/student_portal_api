using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WsnoticeAttach
{
    public int Nsl { get; set; }

    public string? FileName { get; set; }

    public string? Title { get; set; }

    public bool? Status { get; set; }

    public DateTime? PublishdDate { get; set; }

    public string? Ndetails { get; set; }

    public DateTime? NentryDate { get; set; }

    public bool? PinTop { get; set; }

    public bool? IsImportantNews { get; set; }
}
