using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentFailList
{
    public long Sl { get; set; }

    public long? StudentId { get; set; }

    public string? ExInId { get; set; }

    public int? SubQpId { get; set; }

    public double? GetMarks { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
