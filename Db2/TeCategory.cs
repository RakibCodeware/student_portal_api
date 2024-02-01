using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeCategory
{
    public int CategoryId { get; set; }

    public string? Category { get; set; }

    public int? Ordering { get; set; }
}
