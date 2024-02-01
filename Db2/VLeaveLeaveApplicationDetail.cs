using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VLeaveLeaveApplicationDetail
{
    public long Lacode { get; set; }

    public short LeaveId { get; set; }

    public string? LeaveName { get; set; }

    public string? ShortName { get; set; }

    public short? LeaveDays { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? WeekHolydayNo { get; set; }

    public int? TotalDays { get; set; }

    public string? Remarks { get; set; }

    public long Eid { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool? IsProcessessed { get; set; }

    public DateTime? PregnantDate { get; set; }

    public DateTime? PrasaberaDate { get; set; }

    public DateTime? EntryDate { get; set; }

    public bool? IsMeternity { get; set; }

    public short? ShiftId { get; set; }

    public long Sl { get; set; }

    public DateTime? LeaveDate { get; set; }

    public bool? Used { get; set; }

    public string? ShiftName { get; set; }

    public string? Ename { get; set; }

    public string? FromYear { get; set; }

    public string? ToYear { get; set; }

    public long? EcardNo { get; set; }

    public string? DesName { get; set; }

    public short? DesId { get; set; }

    public short? Did { get; set; }

    public string? Dname { get; set; }

    public bool? Dstatus { get; set; }
}
