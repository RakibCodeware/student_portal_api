using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeacherSubjectAllocation
{
    public long Tsaid { get; set; }

    public int? BatchId { get; set; }

    public int? ClsGrpId { get; set; }

    public int? ClasSecId { get; set; }

    public int? SubjectId { get; set; }

    public int? CourseId { get; set; }

    public long? Eid { get; set; }

    public short? ShiftId { get; set; }
}
