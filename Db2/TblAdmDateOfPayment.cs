using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblAdmDateOfPayment
{
    public int AdmDateOfPaymentId { get; set; }

    public int? AdmFeeCatId { get; set; }

    public DateTime? DateOfStart { get; set; }

    public DateTime? DateOfEnd { get; set; }

    public bool? IsActive { get; set; }

    public virtual TblAdmFeesCategory? AdmFeeCat { get; set; }
}
