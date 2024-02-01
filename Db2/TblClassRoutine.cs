using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblClassRoutine
{
    public long ClassRoutineId { get; set; }

    public int DayId { get; set; }

    public short ShiftId { get; set; }

    public int BatchId { get; set; }

    public int? ClsGrpId { get; set; }

    public int ClsSecId { get; set; }

    public int? RoomId { get; set; }

    public int? BatchYear { get; set; }

    public long? Eid { get; set; }

    public int? SubjectId { get; set; }

    public int? CourseId { get; set; }

    public int? ClsTimeId { get; set; }
}
