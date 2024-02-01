using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VCurrentStudentInfo
{
    public long StudentId { get; set; }

    public long? RollNo { get; set; }

    public string? Mobile { get; set; }

    public int? FathersYearlyIncome { get; set; }

    public int? MothersYearlyIncome { get; set; }

    public string? TaviIlage { get; set; }

    public string? TapostOffice { get; set; }

    public string? Tathana { get; set; }

    public string? Tadistrict { get; set; }

    public string? GuardianName { get; set; }

    public string? GuardianRelation { get; set; }

    public string? GuardianMobileNo { get; set; }

    public string? GuardianAddress { get; set; }

    public bool IsActive { get; set; }

    public string? Comments { get; set; }

    public string? Session { get; set; }

    public string? FathersMobile { get; set; }

    public string? MothersMoible { get; set; }

    public string? HomePhone { get; set; }

    public string? BloodGroup { get; set; }

    public string? Religion { get; set; }

    public int? Year { get; set; }

    public string? FullName { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? FathersName { get; set; }

    public string? FathersProfession { get; set; }

    public string? MothersName { get; set; }

    public string? MothersProfession { get; set; }

    public string? Pavillage { get; set; }

    public string? PapostOffice { get; set; }

    public int? PthanaId { get; set; }

    public string? Padistrict { get; set; }

    public string? MotherTongue { get; set; }

    public string? Nationality { get; set; }

    public string? PreviousSchoolName { get; set; }

    public long? TransferCertifiedNo { get; set; }

    public DateTime? CertifiedDate { get; set; }

    public string? PreferredClass { get; set; }

    public double? Pscgpa { get; set; }

    public long? PscrollNo { get; set; }

    public string? Pscboard { get; set; }

    public long? PscpassingYear { get; set; }

    public string? Pscjscregistration { get; set; }

    public string? Pathana { get; set; }

    public string? ImageName { get; set; }

    public long? AdmissionNo { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public short? GroupId { get; set; }

    public string? GroupName { get; set; }

    public short? ClsGrpId { get; set; }

    public short? SectionId { get; set; }

    public string? SectionName { get; set; }

    public short? ClsSecId { get; set; }

    public int? BatchId { get; set; }

    public string? BatchName { get; set; }

    public short? ConfigId { get; set; }

    public string? ShiftName { get; set; }

    public bool? StdStatus { get; set; }

    public short? ClassId { get; set; }

    public string? ClassName { get; set; }

    public short? ClassOrder { get; set; }

    public short ShiftId { get; set; }

    public string? IdCard { get; set; }

    public int? StdTypeId { get; set; }

    public int? PapostOfficeId { get; set; }

    public string? PapostOfficeName { get; set; }

    public int? TapostOfficeId { get; set; }

    public string? TapostOfficeName { get; set; }

    public string? Expr1 { get; set; }

    public string? StdTypeName { get; set; }

    public string? FullNameBn { get; set; }

    public string? FatherNameBn { get; set; }

    public string? MotherNameBn { get; set; }

    public string? FatherDesg { get; set; }

    public string? FatherOrg { get; set; }

    public string? FatherPhone { get; set; }

    public string? MotherDesg { get; set; }

    public string? MotherOrg { get; set; }

    public string? MotherPhone { get; set; }

    public int? BusId { get; set; }

    public string? BusName { get; set; }

    public int? LocationId { get; set; }

    public string? LocationName { get; set; }

    public int? PlaceId { get; set; }

    public string? PlaceName { get; set; }

    public string? TccollegeName { get; set; }

    public DateTime? Tcdate { get; set; }

    public long? Sscroll { get; set; }

    public string? Tcclass { get; set; }

    public string? Tcsemister { get; set; }

    public string? PreviousExamType { get; set; }

    public string? MotherEmail { get; set; }

    public string? FatherEmail { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public string? FirstName { get; set; }

    public string Subject { get; set; } = null!;

    public string ExamDate { get; set; } = null!;

    public string ExamStartTime { get; set; } = null!;

    public string ExamEndTime { get; set; } = null!;

    public string ExamName { get; set; } = null!;

    public string ExamDay { get; set; } = null!;

    public string SubCode { get; set; } = null!;

    public string SubId { get; set; } = null!;

    public string SubCourseId { get; set; } = null!;

    public int GrpRank { get; set; }

    public int SecRank { get; set; }

    public int BatchRank { get; set; }

    public int ShiftRank { get; set; }
}
