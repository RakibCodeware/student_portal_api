using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VDiscountParticularDetail
{
    public int Did { get; set; }

    public long? RollNo { get; set; }

    public short? Pid { get; set; }

    public string? Pname { get; set; }

    public double? Discount { get; set; }

    public long StudentId { get; set; }

    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }
}
