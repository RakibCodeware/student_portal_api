using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AttendanceTransferMedium
{
    public long Sl { get; set; }

    public long? StudentEmpAdmNo { get; set; }

    public DateTime? AttDate { get; set; }

    public short? Hur { get; set; }

    public short? Min { get; set; }

    public short? Sec { get; set; }
}
