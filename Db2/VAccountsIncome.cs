using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VAccountsIncome
{
    public int TitleId { get; set; }

    public string? Title { get; set; }

    public int IncomeId { get; set; }

    public double? Amount { get; set; }

    public DateTime? Date { get; set; }
}
