using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblSmsTransactionLog
{
    public int Sl { get; set; }

    public string? InsertedSmsIds { get; set; }

    public string? Smstype { get; set; }

    public int? Template { get; set; }

    public DateTime? SendingTime { get; set; }
}
