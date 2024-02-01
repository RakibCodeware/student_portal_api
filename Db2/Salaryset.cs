using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Salaryset
{
    public long SaId { get; set; }

    public long? Eid { get; set; }

    public decimal? SaGovtOrBasic { get; set; }

    public decimal? SaSchool { get; set; }

    public decimal? SaTotal { get; set; }

    public string? SaStaus { get; set; }

    public virtual EmployeeInfo? EidNavigation { get; set; }
}
