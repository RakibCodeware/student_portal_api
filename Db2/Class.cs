using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class Class
{
    public short ClassId { get; set; }

    public string? ClassName { get; set; }

    public short? ClassOrder { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<ClassSubject> ClassSubjects { get; } = new List<ClassSubject>();

    public virtual ICollection<TblClassGroup> TblClassGroups { get; } = new List<TblClassGroup>();

    public virtual ICollection<TblClassSection> TblClassSections { get; } = new List<TblClassSection>();

    public virtual ICollection<TblSubjectTeacher> TblSubjectTeachers { get; } = new List<TblSubjectTeacher>();
}
