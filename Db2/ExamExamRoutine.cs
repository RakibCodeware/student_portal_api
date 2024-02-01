using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamExamRoutine
{
    public int ExamRoutineId { get; set; }

    public DateTime? ExamDate { get; set; }

    public string? ExamDay { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public int? ExamId { get; set; }

    public int? BatchId { get; set; }

    public int? ClsGrpId { get; set; }

    public int? SubId { get; set; }

    public int? CourseId { get; set; }

    public int? ShiftId { get; set; }

    public string? BuildingId { get; set; }

    public int? RoomId { get; set; }
}
