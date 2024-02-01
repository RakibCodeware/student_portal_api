using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class UsersForPortal
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int UpdatedBy { get; set; }

    public bool IsActive { get; set; }
}
