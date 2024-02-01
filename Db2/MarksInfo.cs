using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class MarksInfo
{
    public long Mid { get; set; }

    public byte[]? ExInId { get; set; }

    public long? SubId { get; set; }
}
