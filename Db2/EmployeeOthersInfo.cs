using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class EmployeeOthersInfo
{
    public int Sl { get; set; }

    public long? Eid { get; set; }

    public string? OthersInfo { get; set; }

    public virtual EmployeeInfo? EidNavigation { get; set; }
}
