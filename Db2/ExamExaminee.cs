using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamExaminee
{
    public int ExamineeId { get; set; }

    public int ExamId { get; set; }

    public int? BatchId { get; set; }

    public int? ClsGrpId { get; set; }

    public int? ClsSecId { get; set; }

    public int StudentId { get; set; }
}
