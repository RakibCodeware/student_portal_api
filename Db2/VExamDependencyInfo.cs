using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VExamDependencyInfo
{
    public string ExInId { get; set; } = null!;

    public int DeId { get; set; }

    public string? ParentExInId { get; set; }

    public string? DependencyIexamId { get; set; }

    public int? BatchId { get; set; }

    public string BatchName { get; set; } = null!;

    public short? ExId { get; set; }

    public bool? IsFinal { get; set; }
}
