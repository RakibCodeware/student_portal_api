using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentInfoLog
{
    public long Sl { get; set; }

    public string? OrderNo { get; set; }

    public string? Response { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Smsresponse { get; set; }

    public string? ErrorMsg { get; set; }
}
