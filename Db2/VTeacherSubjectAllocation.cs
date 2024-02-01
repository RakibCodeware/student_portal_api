using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VTeacherSubjectAllocation
{
    public long? Eid { get; set; }

    public string? Ename { get; set; }

    public string? TcodeNo { get; set; }

    public int? SubjectId { get; set; }

    public string? SubName { get; set; }

    public int? CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? BatchId { get; set; }

    public int? ClsGrpId { get; set; }

    public int? ClasSecId { get; set; }

    public short? ShiftId { get; set; }

    public long Tsaid { get; set; }
}
