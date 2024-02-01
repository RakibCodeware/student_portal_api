using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentGroupSubSetup
{
    public int SgsubId { get; set; }

    public long? StudentId { get; set; }

    public int? BatchId { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
