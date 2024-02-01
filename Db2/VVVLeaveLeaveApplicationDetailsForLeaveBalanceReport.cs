using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VVVLeaveLeaveApplicationDetailsForLeaveBalanceReport
{
    public long Eid { get; set; }

    public string? Ename { get; set; }

    public long? EcardNo { get; set; }

    public int? Cl { get; set; }

    public int? Sl { get; set; }

    public int? Ml { get; set; }

    public int? Al { get; set; }

    public int? Opl { get; set; }

    public int? Ol { get; set; }

    public int? Total { get; set; }

    public short? LeaveDays { get; set; }

    public int? Remaining { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public DateTime? LeaveDate { get; set; }

    public short? Did { get; set; }

    public string? Dname { get; set; }

    public short? DesId { get; set; }

    public string? DesName { get; set; }
}
