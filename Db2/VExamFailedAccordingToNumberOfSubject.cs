using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VExamFailedAccordingToNumberOfSubject
{
    public int? NumberOfFailSubjectTotal { get; set; }

    public string NumberOfFailSubjectTotalText { get; set; } = null!;

    public int? NumberOfStudent { get; set; }

    public string? RollNo { get; set; }
}
