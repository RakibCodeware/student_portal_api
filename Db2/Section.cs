using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Section
{
    public short SectionId { get; set; }

    public string? SectionName { get; set; }

    public virtual ICollection<TblClassSection> TblClassSections { get; } = new List<TblClassSection>();
}
