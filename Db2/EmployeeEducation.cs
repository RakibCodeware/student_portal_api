using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class EmployeeEducation
{
    public int Slno { get; set; }

    public long? Eid { get; set; }

    public string? EiexamName { get; set; }

    public string? Eidepertment { get; set; }

    public string? Eiboard { get; set; }

    public int? EipassingYear { get; set; }

    public string? Eiresult { get; set; }
}
