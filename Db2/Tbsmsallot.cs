﻿using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Tbsmsallot
{
    public int Reference { get; set; }

    public int Smsref { get; set; }

    public int Userref { get; set; }

    public string? Gentm { get; set; }
}
