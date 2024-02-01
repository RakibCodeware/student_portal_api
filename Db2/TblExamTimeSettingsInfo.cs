using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblExamTimeSettingsInfo
{
    public long ExScId { get; set; }

    public int? ExamTimeSetNameId { get; set; }

    public int? Year { get; set; }

    public short? NoOfPeriod { get; set; }
}
