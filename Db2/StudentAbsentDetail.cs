using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentAbsentDetail
{
    public long AbsenId { get; set; }

    public int? BatchId { get; set; }

    public long? StudentId { get; set; }

    public DateTime? AbsentDate { get; set; }

    public double? AbsentFine { get; set; }

    public DateTime? PayDate { get; set; }

    public bool? IsPaid { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
