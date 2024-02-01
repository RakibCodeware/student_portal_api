using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VTblClassGroup
{
    public short GroupId { get; set; }

    public string? GroupName { get; set; }

    public short? ClassId { get; set; }

    public int? BatchId { get; set; }

    public short ClsGrpId { get; set; }
}
