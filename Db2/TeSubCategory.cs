using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TeSubCategory
{
    public int SubCategoryId { get; set; }

    public int? CategoryId { get; set; }

    public string? SubCategory { get; set; }

    public int? Ordering { get; set; }

    public bool? Status { get; set; }

    public virtual TeCategory? Category { get; set; }
}
