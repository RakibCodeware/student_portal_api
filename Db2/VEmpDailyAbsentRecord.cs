using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VEmpDailyAbsentRecord
{
    public long? Eid { get; set; }

    public long? EcardNo { get; set; }

    public string? Ename { get; set; }

    public DateTime? AttDate { get; set; }

    public string? AttStatus { get; set; }

    public short? Did { get; set; }

    public short? DesId { get; set; }

    public string? DesName { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public bool? Dstatus { get; set; }

    public bool? IsTeacher { get; set; }

    public string? Dname { get; set; }
}
