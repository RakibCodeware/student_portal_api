using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VBatchInfo
{
    public int BatchId { get; set; }

    public string BatchName { get; set; } = null!;

    public bool? IsUsed { get; set; }

    public int? Year { get; set; }

    public short? ClassId { get; set; }

    public short? ClassOrder { get; set; }

    public string? ClassName { get; set; }
}
