using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class DepartmentsHr
{
    public short Did { get; set; }

    public string? Dname { get; set; }

    public bool? Dstatus { get; set; }

    public bool? IsTeacher { get; set; }
}
