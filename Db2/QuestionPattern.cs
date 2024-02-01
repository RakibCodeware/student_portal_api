using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class QuestionPattern
{
    public long Qpid { get; set; }

    public string? Qpname { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<ClassDegree2ndYearMarksSheetTotalResultProcess> ClassDegree2ndYearMarksSheetTotalResultProcesses { get; } = new List<ClassDegree2ndYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassDegree3rdYearMarksSheetTotalResultProcess> ClassDegree3rdYearMarksSheetTotalResultProcesses { get; } = new List<ClassDegree3rdYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassDegreeFirstYearMarksSheetTotalResultProcess> ClassDegreeFirstYearMarksSheetTotalResultProcesses { get; } = new List<ClassDegreeFirstYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassElevenBmtmarksSheetTotalResultProcess> ClassElevenBmtmarksSheetTotalResultProcesses { get; } = new List<ClassElevenBmtmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassElevenMarksSheetTotalResultProcess> ClassElevenMarksSheetTotalResultProcesses { get; } = new List<ClassElevenMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassHonoursFirstYearMarksSheetTotalResultProcess> ClassHonoursFirstYearMarksSheetTotalResultProcesses { get; } = new List<ClassHonoursFirstYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassMastersFinalMarksSheetTotalResultProcess> ClassMastersFinalMarksSheetTotalResultProcesses { get; } = new List<ClassMastersFinalMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassPreliminaryToMastesMarksSheetTotalResultProcess> ClassPreliminaryToMastesMarksSheetTotalResultProcesses { get; } = new List<ClassPreliminaryToMastesMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassTwelveBmtmarksSheetTotalResultProcess> ClassTwelveBmtmarksSheetTotalResultProcesses { get; } = new List<ClassTwelveBmtmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassTwelveMarksSheetTotalResultProcess> ClassTwelveMarksSheetTotalResultProcesses { get; } = new List<ClassTwelveMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXibmmarksSheetTotalResultProcess> ClassXibmmarksSheetTotalResultProcesses { get; } = new List<ClassXibmmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXiibmmarksSheetTotalResultProcess> ClassXiibmmarksSheetTotalResultProcesses { get; } = new List<ClassXiibmmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXiimarksSheetTotalResultProcess> ClassXiimarksSheetTotalResultProcesses { get; } = new List<ClassXiimarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXimarksSheetTotalResultProcess> ClassXimarksSheetTotalResultProcesses { get; } = new List<ClassXimarksSheetTotalResultProcess>();

    public virtual ICollection<SubjectQuestionPattern> SubjectQuestionPatterns { get; } = new List<SubjectQuestionPattern>();
}
