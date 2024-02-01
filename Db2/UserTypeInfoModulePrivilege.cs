using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserTypeInfoModulePrivilege
{
    public long UserTypeDid { get; set; }

    public short? UserTypeId { get; set; }

    public bool? AcademicModule { get; set; }

    public bool? AdministrationModule { get; set; }

    public bool? NotificationModule { get; set; }

    public bool? ReportsModule { get; set; }
}
