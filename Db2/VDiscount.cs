using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDiscount
{
    public long? RollNo { get; set; }

    public double? Discount { get; set; }

    public string? Pname { get; set; }

    public short? Pid { get; set; }

    public int Did { get; set; }

    public long StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public string? ShiftName { get; set; }

    public string? FullName { get; set; }

    public string BatchName { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? SectionName { get; set; }
}
