using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblPhoneGroup
{
    public int GrpId { get; set; }

    public string? GrpName { get; set; }

    public string? Details { get; set; }

    public virtual ICollection<TblPhoneBook> TblPhoneBooks { get; } = new List<TblPhoneBook>();
}
