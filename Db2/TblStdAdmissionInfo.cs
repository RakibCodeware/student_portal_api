using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblStdAdmissionInfo
{
    public int AdmissionId { get; set; }

    public long? AdmissionNo { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public long? StudentId { get; set; }

    public short? ClassId { get; set; }

    public short? ClsSecId { get; set; }

    public int? RollNo { get; set; }

    public int? StartBatchId { get; set; }

    public int? EndBatchId { get; set; }

    public bool? StdStatus { get; set; }

    public string? Session { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
