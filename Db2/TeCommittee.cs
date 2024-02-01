using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeCommittee
{
    public int Sl { get; set; }

    public int? SessionId { get; set; }

    public int? MemberId { get; set; }

    public virtual TeSession? Session { get; set; }
}
