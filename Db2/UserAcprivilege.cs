﻿using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserAcprivilege
{
    public int UserId { get; set; }

    public int DeviceId { get; set; }

    public int? AcgroupId { get; set; }

    public bool? IsUseGroup { get; set; }

    public int? TimeZone1 { get; set; }

    public int? TimeZone2 { get; set; }

    public int? TimeZone3 { get; set; }

    public int? Verifystyle { get; set; }
}
