using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblSmsBody
{
    public int TitleId { get; set; }

    public string Title { get; set; } = null!;

    public string? Body { get; set; }
}
