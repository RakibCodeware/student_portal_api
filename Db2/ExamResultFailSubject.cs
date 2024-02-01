using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamResultFailSubject
{
    public int Sl { get; set; }

    public long? ResultId { get; set; }

    public long? ExamId { get; set; }

    public int? StudentId { get; set; }

    public int? SubId { get; set; }

    public int? CourseId { get; set; }

    public bool? IsAbsent { get; set; }

    public bool? IsOptionalSub { get; set; }

    public virtual ExamResultSheet? Result { get; set; }
}
