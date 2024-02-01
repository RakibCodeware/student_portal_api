using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VClasswiseSubject
{
    public short? ClassId { get; set; }

    public long? SubId { get; set; }

    public string? SubName { get; set; }

    public int? Ordering { get; set; }

    public string? ClassName { get; set; }

    public string? SubCode { get; set; }
}
