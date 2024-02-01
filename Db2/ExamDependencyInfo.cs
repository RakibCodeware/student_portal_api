using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamDependencyInfo
{
    public int DeId { get; set; }

    public string? ParentExInId { get; set; }

    public string? DependencyIexamId { get; set; }

    public bool? IsFinal { get; set; }

    public virtual ExamInfo? ParentExIn { get; set; }
}
