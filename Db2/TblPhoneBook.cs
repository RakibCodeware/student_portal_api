using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblPhoneBook
{
    public int NumId { get; set; }

    public string? Number { get; set; }

    public int? GrpId { get; set; }

    public string? Name { get; set; }

    public string? Details { get; set; }

    public virtual TblPhoneGroup? Grp { get; set; }
}
