using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblTransaction
{
    public int TrnsId { get; set; }

    public long? TransactionNo { get; set; }

    public string? Purpose { get; set; }

    public long? StudentId { get; set; }

    public string? OthersId { get; set; }

    public string? ReferenceId { get; set; }

    public DateTime? TransactionDate { get; set; }
}
