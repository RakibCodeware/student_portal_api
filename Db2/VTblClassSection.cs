using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VTblClassSection
{
    public int BatchId { get; set; }

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public short? SectionId { get; set; }

    public string? SectionName { get; set; }

    public short ClsSecId { get; set; }

    public short? ClsGrpId { get; set; }

    public bool? IsUsed { get; set; }

    public string BatchName { get; set; } = null!;
}
