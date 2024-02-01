using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class EmployeeExperience
{
    public int Slno { get; set; }

    public long? Eid { get; set; }

    public string? ExIinstName { get; set; }

    public string? ExIdesignation { get; set; }

    public DateTime? ExIddateFrom { get; set; }

    public DateTime? ExIdateTo { get; set; }

    public string? ExIduration { get; set; }
}
