using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VTblClassRoutine
{
    public long ClassRoutineId { get; set; }

    public int DayId { get; set; }

    public short ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public int BatchId { get; set; }

    public string BatchName { get; set; } = null!;

    public int? ClsGrpId { get; set; }

    public string? GroupName { get; set; }

    public int ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public int? RoomId { get; set; }

    public string? RoomName { get; set; }

    public string? BuildingName { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public int? BatchYear { get; set; }

    public string DayName { get; set; } = null!;

    public short? Did { get; set; }

    public string? Dname { get; set; }

    public string? DesName { get; set; }

    public long? EcardNo { get; set; }

    public long? SubId { get; set; }

    public string? SubName { get; set; }

    public string? CourseName { get; set; }

    public long? Eid { get; set; }

    public int? SubjectId { get; set; }

    public int? CourseId { get; set; }

    public string? TcodeNo { get; set; }

    public string? Ename { get; set; }

    public int? ClsTimeId { get; set; }

    public string? ShortDayName { get; set; }
}
