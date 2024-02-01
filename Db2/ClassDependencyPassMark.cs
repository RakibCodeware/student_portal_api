using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ClassDependencyPassMark
{
    public int ClsDepId { get; set; }

    public int? ClassId { get; set; }

    public int? SubId { get; set; }

    public double? PassMarks { get; set; }
}
