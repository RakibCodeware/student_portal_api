using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblSmsReport
{
    public int SmsreportId { get; set; }

    public decimal? Smsid { get; set; }

    public string? MobileNo { get; set; }

    public string? MessageBody { get; set; }

    public string? Purpose { get; set; }

    public DateTime? SentTime { get; set; }

    public string? Status { get; set; }
}
