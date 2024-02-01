using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VAccountsExpense
{
    public int TitleId { get; set; }

    public string? Title { get; set; }

    public int ExpensesId { get; set; }

    public double? Amount { get; set; }

    public DateTime? Date { get; set; }
}
