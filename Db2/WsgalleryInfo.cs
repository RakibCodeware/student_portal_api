using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WsgalleryInfo
{
    public int Pasl { get; set; }

    public string? AlbumName { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }
}
