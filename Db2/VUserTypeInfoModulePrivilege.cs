using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VUserTypeInfoModulePrivilege
{
    public long UserTypeDid { get; set; }

    public short? UserTypeId { get; set; }

    public string UserType { get; set; } = null!;

    public bool? AcademicModule { get; set; }

    public bool? AdministrationModule { get; set; }

    public bool? NotificationModule { get; set; }

    public bool? ReportsModule { get; set; }

    public bool? IsActive { get; set; }
}
