using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Discount
{
    public int Did { get; set; }

    public long StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public long? RollNo { get; set; }

    public short? Pid { get; set; }

    public double? Discount1 { get; set; }

    public virtual ParticularsInfo? PidNavigation { get; set; }

    public virtual CurrentStudentInfo Student { get; set; } = null!;
}
