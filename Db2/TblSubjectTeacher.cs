using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblSubjectTeacher
{
    public int SubTecherId { get; set; }

    public long SubId { get; set; }

    public long Eid { get; set; }

    public short ClassId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual EmployeeInfo EidNavigation { get; set; } = null!;

    public virtual NewSubject Sub { get; set; } = null!;
}
