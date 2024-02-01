using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VStudentGroupSubSetup
{
    public int SgsubId { get; set; }

    public long? StudentId { get; set; }

    public int? BatchId { get; set; }

    public int? SubId { get; set; }

    public bool? Msstatus { get; set; }

    public short? Ordering { get; set; }
}
