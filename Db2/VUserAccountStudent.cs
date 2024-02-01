using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VUserAccountStudent
{
    public long StudentAccId { get; set; }

    public long? StudentId { get; set; }

    public string? FullName { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool Status { get; set; }
}
