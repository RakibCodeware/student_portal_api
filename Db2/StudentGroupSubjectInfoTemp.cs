using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentGroupSubjectInfoTemp
{
    public long SgsId { get; set; }

    public long StudentId { get; set; }

    public short ClassId { get; set; }

    public short ClsGrpId { get; set; }

    public int BatchId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ApprovedAt { get; set; }

    public long AprovedBy { get; set; }

    public virtual ICollection<StudentGroupSubjectDetailsTemp> StudentGroupSubjectDetailsTemps { get; } = new List<StudentGroupSubjectDetailsTemp>();
}
