using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentErrorLog
{
    public int Sl { get; set; }

    public string? ErrorMsg { get; set; }

    public DateTime? CreatedAt { get; set; }
}
