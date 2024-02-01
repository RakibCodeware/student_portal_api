using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentActivationLog
{
    public int Sl { get; set; }

    public long? StudentId { get; set; }

    public int? BatchId { get; set; }

    public DateTime? Date { get; set; }

    public string? Note { get; set; }

    public bool? ActivationType { get; set; }

    public DateTime? EntryDate { get; set; }
}
