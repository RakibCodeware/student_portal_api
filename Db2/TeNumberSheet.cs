using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeNumberSheet
{
    public long? Eid { get; set; }

    public int? SessionId { get; set; }

    public int? MemberId { get; set; }

    public int? SubCategoryId { get; set; }

    public double? ObtainNumber { get; set; }

    public virtual TeSession? Session { get; set; }
}
