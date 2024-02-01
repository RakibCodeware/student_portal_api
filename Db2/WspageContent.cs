using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WspageContent
{
    public string PageId { get; set; } = null!;

    public string? Title { get; set; }

    public string? Image { get; set; }

    public string? TextContent { get; set; }

    public bool? Status { get; set; }

    public DateTime? EntryTime { get; set; }
}
