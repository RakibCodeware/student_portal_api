using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VAdmStudentPaymentInfo
{
    public short? ShiftId { get; set; }

    public int? BatchId { get; set; }

    public short? ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public long? RollNo { get; set; }

    public int? FeeCatId { get; set; }

    public bool? PayStatus { get; set; }

    public string? FeeCatName { get; set; }

    public double? FeeAmount { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public string? ClassName { get; set; }

    public string? ShiftName { get; set; }

    public double? AmountPaid { get; set; }

    public long? StudentId { get; set; }
}
