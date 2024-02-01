using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDailyAbsentRecord
{
    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public DateTime? AttDate { get; set; }

    public string? AttStatus { get; set; }

    public string? FullName { get; set; }

    public short? ClsSecId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? BatchId { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public string BatchName { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? SectionName { get; set; }

    public string? ClassName { get; set; }

    public short? ClassOrder { get; set; }

    public string? GuardianMobileNo { get; set; }
}
