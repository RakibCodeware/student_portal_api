using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Wsebook
{
    public short Id { get; set; }

    public string? BookTiltle { get; set; }

    public string? BookImage { get; set; }

    public string? BookReadUrl { get; set; }

    public string? BookDownUrl { get; set; }

    public short? BookCatagory { get; set; }
}
