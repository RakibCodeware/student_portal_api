using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ClassesAdmission
{
    public short ClassId { get; set; }

    public short AdmissionYear { get; set; }

    public bool? IsActive { get; set; }
}
