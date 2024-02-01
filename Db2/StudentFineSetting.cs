using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentFineSetting
{
    public int Sfsid { get; set; }

    public string? FinePurpose { get; set; }

    public double? Amount { get; set; }
}
