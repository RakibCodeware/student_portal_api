using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AccountsIncome
{
    public int IncomeId { get; set; }

    public int? TitleId { get; set; }

    public double? Amount { get; set; }

    public DateTime? Date { get; set; }

    public string? Particular { get; set; }

    public virtual AccountsTitle? Title { get; set; }
}
