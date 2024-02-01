using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ExamType
{
    public short ExId { get; set; }

    public string? ExName { get; set; }

    public bool? SemesterExam { get; set; }

    public int? Ordering { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<ClassDegree2ndYearMarksSheet> ClassDegree2ndYearMarksSheets { get; } = new List<ClassDegree2ndYearMarksSheet>();

    public virtual ICollection<ClassDegree3rdYearMarksSheet> ClassDegree3rdYearMarksSheets { get; } = new List<ClassDegree3rdYearMarksSheet>();

    public virtual ICollection<ClassDegreeFirstYearMarksSheet> ClassDegreeFirstYearMarksSheets { get; } = new List<ClassDegreeFirstYearMarksSheet>();

    public virtual ICollection<ClassElevenBmtmarksSheet> ClassElevenBmtmarksSheets { get; } = new List<ClassElevenBmtmarksSheet>();

    public virtual ICollection<ClassElevenMarksSheet> ClassElevenMarksSheets { get; } = new List<ClassElevenMarksSheet>();

    public virtual ICollection<ClassHonoursFirstYearMarksSheet> ClassHonoursFirstYearMarksSheets { get; } = new List<ClassHonoursFirstYearMarksSheet>();

    public virtual ICollection<ClassMastersFinalMarksSheet> ClassMastersFinalMarksSheets { get; } = new List<ClassMastersFinalMarksSheet>();

    public virtual ICollection<ClassPreliminaryToMastesMarksSheet> ClassPreliminaryToMastesMarksSheets { get; } = new List<ClassPreliminaryToMastesMarksSheet>();

    public virtual ICollection<ClassTwelveBmtmarksSheet> ClassTwelveBmtmarksSheets { get; } = new List<ClassTwelveBmtmarksSheet>();

    public virtual ICollection<ClassTwelveMarksSheet> ClassTwelveMarksSheets { get; } = new List<ClassTwelveMarksSheet>();

    public virtual ICollection<ClassXibmmarksSheet> ClassXibmmarksSheets { get; } = new List<ClassXibmmarksSheet>();

    public virtual ICollection<ClassXiibmmarksSheet> ClassXiibmmarksSheets { get; } = new List<ClassXiibmmarksSheet>();

    public virtual ICollection<ClassXiimarksSheet> ClassXiimarksSheets { get; } = new List<ClassXiimarksSheet>();

    public virtual ICollection<ClassXimarksSheet> ClassXimarksSheets { get; } = new List<ClassXimarksSheet>();

    public virtual ICollection<SubjectQuestionPattern> SubjectQuestionPatterns { get; } = new List<SubjectQuestionPattern>();
}
