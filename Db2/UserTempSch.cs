﻿using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UserTempSch
{
    public int Userid { get; set; }

    public DateTime Cometime { get; set; }

    public DateTime Leavetime { get; set; }

    public int Overtime { get; set; }

    public short? Type { get; set; }

    public short? Flag { get; set; }

    public int? Schclassid { get; set; }
}
