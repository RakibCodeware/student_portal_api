using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VSalarySetDetail
{
    public long Eid { get; set; }

    public string? Ename { get; set; }

    public string? DesName { get; set; }

    public decimal? SaGovtOrBasic { get; set; }

    public decimal? SaSchool { get; set; }

    public decimal? SaTotal { get; set; }

    public string? SaStaus { get; set; }

    public short? Did { get; set; }

    public string? Dname { get; set; }
}
