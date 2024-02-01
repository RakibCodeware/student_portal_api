using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class CurrentStudentLog
{
    public long? StudentId { get; set; }

    public short? ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public long? RollNo { get; set; }

    public short? ConfigId { get; set; }

    public int? BatchId { get; set; }

    public int? SpendYear { get; set; }

    public virtual BatchInfo? Batch { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ShiftConfiguration? Config { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
