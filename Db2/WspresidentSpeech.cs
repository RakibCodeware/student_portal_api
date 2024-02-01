using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class WspresidentSpeech
{
    public byte Psl { get; set; }

    public string? Pspeech { get; set; }

    public string? PresidentName { get; set; }

    public string? ImagePath { get; set; }
}
