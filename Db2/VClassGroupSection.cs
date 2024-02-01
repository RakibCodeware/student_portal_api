using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VClassGroupSection
{
    public short ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? GroupId { get; set; }

    public string? GroupName { get; set; }

    public short? ClsSecId { get; set; }

    public short? SectionId { get; set; }

    public string? SectionName { get; set; }
}
