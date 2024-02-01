using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentGroupSubjectDetailsTemp
{
    public long Id { get; set; }

    public long SubId { get; set; }

    public bool Msstatus { get; set; }

    public long SgsId { get; set; }

    public virtual StudentGroupSubjectInfoTemp Sgs { get; set; } = null!;
}
