using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VAdmFeesCatDetail
{
    public short? ClassId { get; set; }

    public string? FeeCatName { get; set; }

    public int AdmCatPid { get; set; }

    public int? AdmFeeCatId { get; set; }

    public double? Amount { get; set; }

    public short Pid { get; set; }

    public string? Pname { get; set; }

    public string? ClassName { get; set; }
}
