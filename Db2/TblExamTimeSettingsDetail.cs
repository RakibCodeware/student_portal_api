using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblExamTimeSettingsDetail
{
    public long ExScSl { get; set; }

    public long? ExScId { get; set; }

    public DateTime? ExamDate { get; set; }

    public string? ExamTimeDuration1 { get; set; }

    public string? Details1 { get; set; }

    public string? ExamTimeDuration2 { get; set; }

    public string? Details2 { get; set; }

    public string? ExamTimeDuration3 { get; set; }

    public string? Details3 { get; set; }

    public string? ExamTimeDuration4 { get; set; }

    public string? Details4 { get; set; }

    public string? ExamTimeDuration5 { get; set; }

    public string? Details5 { get; set; }

    public virtual TblExamTimeSettingsInfo? ExSc { get; set; }
}
