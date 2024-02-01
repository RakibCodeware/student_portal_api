using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class LeaveConfiguration
{
    public short LeaveId { get; set; }

    public string? LeaveName { get; set; }

    public string? ShortName { get; set; }

    public short? LeaveDays { get; set; }

    public string? LeaveNature { get; set; }

    public bool? DeductionAllowed { get; set; }

    public int? Year { get; set; }
}
