using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentGroupSubSetupDetail
{
    public int? SgsubId { get; set; }

    public int? SubId { get; set; }

    public bool? Msstatus { get; set; }

    public virtual StudentGroupSubSetup? Sgsub { get; set; }
}
