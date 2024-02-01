using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblGuideTeacher
{
    public long? StudentId { get; set; }

    public long? Eid { get; set; }

    public bool? GuideStatus { get; set; }

    public virtual EmployeeInfo? EidNavigation { get; set; }

    public virtual CurrentStudentInfo? Student { get; set; }
}
