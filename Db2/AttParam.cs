﻿using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AttParam
{
    public string Paraname { get; set; } = null!;

    public string? Paratype { get; set; }

    public string Paravalue { get; set; } = null!;
}
