using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WseventInfo
{
    public int Esl { get; set; }

    public string? EventName { get; set; }

    public bool? IsActive { get; set; }

    public string? Notes { get; set; }
}
