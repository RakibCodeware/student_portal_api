using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentAttendance
{
    public long AttenId { get; set; }

    public string? BatchName { get; set; }

    public long? StudentId { get; set; }

    public DateTime? AttenDate { get; set; }

    public TimeSpan? TimeEntrance { get; set; }

    public TimeSpan? TimeExit { get; set; }

    public int? UserId { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
