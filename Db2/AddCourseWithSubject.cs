using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AddCourseWithSubject
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public short? Ordering { get; set; }

    public long? SubId { get; set; }

    public bool? IsActive { get; set; }

    public virtual NewSubject? Sub { get; set; }
}
