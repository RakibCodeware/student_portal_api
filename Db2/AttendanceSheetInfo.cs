using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AttendanceSheetInfo
{
    public int Id { get; set; }

    public string Asname { get; set; } = null!;

    public string Batch { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string Section { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;
}
