using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class AccountsTitle
{
    public int TitleId { get; set; }

    public string? Title { get; set; }

    public bool? Type { get; set; }
}
