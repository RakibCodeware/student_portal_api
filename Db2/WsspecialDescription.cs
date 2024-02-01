using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WsspecialDescription
{
    public short Dsl { get; set; }

    public string? Dsubject { get; set; }

    public string? Details { get; set; }

    public string? Type { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? PublishDate { get; set; }

    public string? Image { get; set; }
}
