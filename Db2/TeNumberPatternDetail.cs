using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeNumberPatternDetail
{
    public int Sl { get; set; }

    public int? NumPatternId { get; set; }

    public int? SubCategoryId { get; set; }

    public double? FullNumber { get; set; }

    public double? Excellent { get; set; }

    public double? Good { get; set; }

    public double? Medium { get; set; }

    public double? Weak { get; set; }

    public double? SoWeak { get; set; }

    public virtual TeNumberPattern? NumPattern { get; set; }
}
