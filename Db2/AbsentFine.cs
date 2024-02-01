using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AbsentFine
{
    public int Afid { get; set; }

    public double? AbsentFineAmount { get; set; }

    public DateTime? Date { get; set; }

    public bool? IsActive { get; set; }
}
