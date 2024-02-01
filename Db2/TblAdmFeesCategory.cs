using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblAdmFeesCategory
{
    public int AdmFeeCatId { get; set; }

    public string? FeeCatName { get; set; }

    public short? ClassId { get; set; }

    public DateTime? DateOfCreation { get; set; }

    public double? FeeAmount { get; set; }

    public virtual ICollection<TblAdmDateOfPayment> TblAdmDateOfPayments { get; } = new List<TblAdmDateOfPayment>();

    public virtual ICollection<TblAdmParticularsCategory> TblAdmParticularsCategories { get; } = new List<TblAdmParticularsCategory>();
}
