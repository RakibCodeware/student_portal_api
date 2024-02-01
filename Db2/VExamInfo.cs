using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VExamInfo
{
    public string? GroupName { get; set; }

    public long ExInSl { get; set; }

    public string ExInId { get; set; } = null!;

    public DateTime? ExStartDate { get; set; }

    public int? BatchId { get; set; }

    public short? ExId { get; set; }

    public DateTime? ExEndDate { get; set; }

    public string? ExName { get; set; }

    public bool? IsPublished { get; set; }

    public int? ClsGrpId { get; set; }
}
