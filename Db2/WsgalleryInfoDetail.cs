using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WsgalleryInfoDetail
{
    public int Sl { get; set; }

    public int? Pasl { get; set; }

    public string? Title { get; set; }

    public string? Location { get; set; }

    public string? ShortDes { get; set; }

    public virtual WsgalleryInfo? PaslNavigation { get; set; }
}
