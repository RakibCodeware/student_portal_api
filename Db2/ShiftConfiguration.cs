using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class ShiftConfiguration
{
    public short ConfigId { get; set; }

    public string? ShiftName { get; set; }

    public string? StartTime { get; set; }

    public string? CloseTime { get; set; }

    public string? LateTime { get; set; }

    public string? AbsentTime { get; set; }

    public bool? Type { get; set; }

    public virtual ICollection<ClassDegree2ndYearMarksSheetTotalResultProcess> ClassDegree2ndYearMarksSheetTotalResultProcesses { get; } = new List<ClassDegree2ndYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassDegree2ndYearMarksSheet> ClassDegree2ndYearMarksSheets { get; } = new List<ClassDegree2ndYearMarksSheet>();

    public virtual ICollection<ClassDegree3rdYearMarksSheetTotalResultProcess> ClassDegree3rdYearMarksSheetTotalResultProcesses { get; } = new List<ClassDegree3rdYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassDegree3rdYearMarksSheet> ClassDegree3rdYearMarksSheets { get; } = new List<ClassDegree3rdYearMarksSheet>();

    public virtual ICollection<ClassDegreeFirstYearMarksSheetTotalResultProcess> ClassDegreeFirstYearMarksSheetTotalResultProcesses { get; } = new List<ClassDegreeFirstYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassDegreeFirstYearMarksSheet> ClassDegreeFirstYearMarksSheets { get; } = new List<ClassDegreeFirstYearMarksSheet>();

    public virtual ICollection<ClassElevenBmtmarksSheetTotalResultProcess> ClassElevenBmtmarksSheetTotalResultProcesses { get; } = new List<ClassElevenBmtmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassElevenBmtmarksSheet> ClassElevenBmtmarksSheets { get; } = new List<ClassElevenBmtmarksSheet>();

    public virtual ICollection<ClassElevenMarksSheetTotalResultProcess> ClassElevenMarksSheetTotalResultProcesses { get; } = new List<ClassElevenMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassElevenMarksSheet> ClassElevenMarksSheets { get; } = new List<ClassElevenMarksSheet>();

    public virtual ICollection<ClassHonoursFirstYearMarksSheetTotalResultProcess> ClassHonoursFirstYearMarksSheetTotalResultProcesses { get; } = new List<ClassHonoursFirstYearMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassHonoursFirstYearMarksSheet> ClassHonoursFirstYearMarksSheets { get; } = new List<ClassHonoursFirstYearMarksSheet>();

    public virtual ICollection<ClassMastersFinalMarksSheetTotalResultProcess> ClassMastersFinalMarksSheetTotalResultProcesses { get; } = new List<ClassMastersFinalMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassMastersFinalMarksSheet> ClassMastersFinalMarksSheets { get; } = new List<ClassMastersFinalMarksSheet>();

    public virtual ICollection<ClassPreliminaryToMastesMarksSheetTotalResultProcess> ClassPreliminaryToMastesMarksSheetTotalResultProcesses { get; } = new List<ClassPreliminaryToMastesMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassPreliminaryToMastesMarksSheet> ClassPreliminaryToMastesMarksSheets { get; } = new List<ClassPreliminaryToMastesMarksSheet>();

    public virtual ICollection<ClassTwelveBmtmarksSheetTotalResultProcess> ClassTwelveBmtmarksSheetTotalResultProcesses { get; } = new List<ClassTwelveBmtmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassTwelveBmtmarksSheet> ClassTwelveBmtmarksSheets { get; } = new List<ClassTwelveBmtmarksSheet>();

    public virtual ICollection<ClassTwelveMarksSheetTotalResultProcess> ClassTwelveMarksSheetTotalResultProcesses { get; } = new List<ClassTwelveMarksSheetTotalResultProcess>();

    public virtual ICollection<ClassTwelveMarksSheet> ClassTwelveMarksSheets { get; } = new List<ClassTwelveMarksSheet>();

    public virtual ICollection<ClassXibmmarksSheetTotalResultProcess> ClassXibmmarksSheetTotalResultProcesses { get; } = new List<ClassXibmmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXibmmarksSheet> ClassXibmmarksSheets { get; } = new List<ClassXibmmarksSheet>();

    public virtual ICollection<ClassXiibmmarksSheetTotalResultProcess> ClassXiibmmarksSheetTotalResultProcesses { get; } = new List<ClassXiibmmarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXiibmmarksSheet> ClassXiibmmarksSheets { get; } = new List<ClassXiibmmarksSheet>();

    public virtual ICollection<ClassXiimarksSheetTotalResultProcess> ClassXiimarksSheetTotalResultProcesses { get; } = new List<ClassXiimarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXiimarksSheet> ClassXiimarksSheets { get; } = new List<ClassXiimarksSheet>();

    public virtual ICollection<ClassXimarksSheetTotalResultProcess> ClassXimarksSheetTotalResultProcesses { get; } = new List<ClassXimarksSheetTotalResultProcess>();

    public virtual ICollection<ClassXimarksSheet> ClassXimarksSheets { get; } = new List<ClassXimarksSheet>();
}
