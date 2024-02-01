using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentInfoIpnLog
{
    public long Sl { get; set; }

    public string? OrderNo { get; set; }

    public string? Response { get; set; }

    public string? Smsresponse { get; set; }

    public DateTime? CreatedAt { get; set; }
}
