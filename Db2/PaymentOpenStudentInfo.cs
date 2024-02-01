using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class PaymentOpenStudentInfo
{
    public int Id { get; set; }

    public string? MobileNo { get; set; }

    public string? StudentName { get; set; }

    public int? ClassId { get; set; }

    public int? ClsGrpId { get; set; }

    public string? RegNo { get; set; }

    public string? RollNo { get; set; }

    public int? Year { get; set; }

    public string? FathersName { get; set; }

    public int? FeeCatId { get; set; }
}
