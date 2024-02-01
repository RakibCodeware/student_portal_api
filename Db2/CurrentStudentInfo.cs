using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class CurrentStudentInfo
{
    public long StudentId { get; set; }

    public int? AdmissionNo { get; set; }

    public string? FullName { get; set; }

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public string? SectionName { get; set; }

    public long? RollNo { get; set; }

    public string? Religion { get; set; }

    public short? ConfigId { get; set; }

    public string? Shift { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Mobile { get; set; }

    public string? Session { get; set; }

    public string? BloodGroup { get; set; }

    public string? FathersName { get; set; }

    public string? FathersProfession { get; set; }

    public int? FathersYearlyIncome { get; set; }

    public string? FathersMobile { get; set; }

    public string? FatherEmail { get; set; }

    public string? MothersName { get; set; }

    public string? MothersProfession { get; set; }

    public int? MothersYearlyIncome { get; set; }

    public string? MothersMoible { get; set; }

    public string? MotherEmail { get; set; }

    public string? HomePhone { get; set; }

    public string? GuardianName { get; set; }

    public string? GuardianRelation { get; set; }

    public string? GuardianMobileNo { get; set; }

    public string? GuardianAddress { get; set; }

    public string? Pavillage { get; set; }

    public string? PapostOffice { get; set; }

    public int? PthanaId { get; set; }

    public string? Pathana { get; set; }

    public short? PdistrictId { get; set; }

    public string? Padistrict { get; set; }

    public string? TaviIlage { get; set; }

    public string? TapostOffice { get; set; }

    public int? TthanaId { get; set; }

    public string? Tathana { get; set; }

    public short? TdistrictId { get; set; }

    public string? Tadistrict { get; set; }

    public string? MotherTongue { get; set; }

    public string? Nationality { get; set; }

    public string? PreviousExamType { get; set; }

    public long? PscrollNo { get; set; }

    public long? PscpassingYear { get; set; }

    public double? Pscgpa { get; set; }

    public string? Pscboard { get; set; }

    public DateTime? CertifiedDate { get; set; }

    public string? PreviousSchoolName { get; set; }

    public string? Pscjscregistration { get; set; }

    public long? TransferCertifiedNo { get; set; }

    public string? PreferredClass { get; set; }

    public bool IsActive { get; set; }

    public string? Comments { get; set; }

    public int? BatchId { get; set; }

    public string? BatchName { get; set; }

    public string? Status { get; set; }

    public bool? PaymentStatus { get; set; }

    public int? SpendYear { get; set; }

    public string? ImageName { get; set; }

    public string? FullNameBn { get; set; }

    public string? FatherNameBn { get; set; }

    public string? MotherNameBn { get; set; }

    public string? IdCard { get; set; }

    public int? StdTypeId { get; set; }

    public int? PapostOfficeId { get; set; }

    public int? TapostOfficeId { get; set; }

    public string? FatherDesg { get; set; }

    public string? FatherOrg { get; set; }

    public string? FatherPhone { get; set; }

    public string? MotherDesg { get; set; }

    public string? MotherOrg { get; set; }

    public string? MotherPhone { get; set; }

    public int? BusId { get; set; }

    public int? LocationId { get; set; }

    public int? PlaceId { get; set; }

    public string? TccollegeName { get; set; }

    public DateTime? Tcdate { get; set; }

    public string? Tcclass { get; set; }

    public string? Tcsemister { get; set; }

    public long? Sscroll { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public string? FathersProfessionBn { get; set; }

    public string? MothersProfessionBn { get; set; }

    public string? TaviIlageBn { get; set; }

    public string? PavillageBn { get; set; }

    public string? ParentsAddress { get; set; }

    public string? ParentsAddressBn { get; set; }

    public int? ParentsPostOfficeId { get; set; }

    public int? ParentsThanaId { get; set; }

    public int? ParentsDistrictId { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

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

    public virtual ICollection<StudentFailList> StudentFailLists { get; } = new List<StudentFailList>();

    public virtual ICollection<StudentGroupSubSetup> StudentGroupSubSetups { get; } = new List<StudentGroupSubSetup>();

    public virtual ICollection<TblStdAdmissionInfo> TblStdAdmissionInfos { get; } = new List<TblStdAdmissionInfo>();
}
