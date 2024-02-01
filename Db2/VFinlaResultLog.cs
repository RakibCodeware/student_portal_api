using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VFinlaResultLog
{
    public long Sl { get; set; }

    public string? ExInId { get; set; }

    public long? StudentId { get; set; }

    public long? SubId { get; set; }

    public double? Marks { get; set; }

    public string? Sgrade { get; set; }

    public double? Spoint { get; set; }

    public string? Gpa { get; set; }

    public string? Grade { get; set; }

    public string? TotalMarks { get; set; }

    public long? RollNo { get; set; }

    public string? Shift { get; set; }

    public string? SectionName { get; set; }

    public string? BatchName { get; set; }

    public string? SubName { get; set; }

    public string? FullName { get; set; }
}
