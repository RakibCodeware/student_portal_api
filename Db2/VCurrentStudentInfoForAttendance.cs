using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VCurrentStudentInfoForAttendance
{
    public long StudentId { get; set; }

    public string? FullName { get; set; }

    public short? ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public long? RollNo { get; set; }

    public short? ConfigId { get; set; }

    public int AdmissionId { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public bool IsActive { get; set; }

    public int? BatchId { get; set; }
}
