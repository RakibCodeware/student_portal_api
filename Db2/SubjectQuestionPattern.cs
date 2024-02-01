using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class SubjectQuestionPattern
{
    public int SubQpid { get; set; }

    public short? ExId { get; set; }

    public short? BatchId { get; set; }

    public short? ClsGrpId { get; set; }

    public long? SubId { get; set; }

    public int? CourseId { get; set; }

    public long? Qpid { get; set; }

    public double? Qmarks { get; set; }

    public double? PassMarks { get; set; }

    public double? ConvertTo { get; set; }

    public bool? IsOptional { get; set; }

    public double? SubQpmarks { get; set; }

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

    public virtual ExamType? Ex { get; set; }

    public virtual QuestionPattern? Qp { get; set; }
}
