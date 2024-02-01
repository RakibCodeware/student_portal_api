using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class SchoolSetup
{
    public short Dsid { get; set; }

    public string? SchoolName { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? RegistrationNo { get; set; }

    public string? Email { get; set; }

    public string? LogoName { get; set; }

    public string? EmailPassword { get; set; }

    public bool IsOnline { get; set; }
}
