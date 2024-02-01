using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblSectionChangeLog
{
    public int Sl { get; set; }

    public long? StudentId { get; set; }

    public short? PreClsSecId { get; set; }

    public short? NewClsSecId { get; set; }

    public DateTime? ChangeDate { get; set; }
}
