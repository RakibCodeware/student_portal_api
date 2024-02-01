using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Wsnotice
{
    public long Nsl { get; set; }

    public string? Nsubject { get; set; }

    public string? Ndetails { get; set; }

    public DateTime? NentryDate { get; set; }

    public DateTime? NpublishedDate { get; set; }

    public long? Nordering { get; set; }

    public bool? IsActive { get; set; }

    public string? Type { get; set; }

    public string? FileName { get; set; }
}
