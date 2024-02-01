using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblExamTimeSpecification
{
    public int ExamTimeId { get; set; }

    public string Name { get; set; } = null!;

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string? Period { get; set; }

    public int OrderBy { get; set; }

    public bool IsBreakTime { get; set; }

    public int? ExamTimeSetNameId { get; set; }
}
