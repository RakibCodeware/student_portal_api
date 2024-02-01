using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class StudentAdmissionFormInfo
{
    public long Sl { get; set; }

    public int AdmissionFormNo { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public int? AdmissionYear { get; set; }

    public string? FullName { get; set; }

    public string? FullNameBn { get; set; }

    public short? ClassId { get; set; }

    public short? ClsGrpId { get; set; }

    public short? ClsSecId { get; set; }

    public string? Gender { get; set; }

    public string? Religion { get; set; }

    public string? ShiftId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Mobile { get; set; }

    public string? BloodGroup { get; set; }

    public string? Session { get; set; }

    public string? FathersName { get; set; }

    public string? FathersNameBn { get; set; }

    public string? FathersProfession { get; set; }

    public string? FathersProfessionBn { get; set; }

    public string? FathersMobile { get; set; }

    public string? MothersName { get; set; }

    public string? MothersNameBn { get; set; }

    public string? MothersProfession { get; set; }

    public string? MothersProfessionBn { get; set; }

    public string? MothersMobile { get; set; }

    public string? ParentsAddress { get; set; }

    public string? ParentsAddressBn { get; set; }

    public int? ParentsPostOfficeId { get; set; }

    public int? ParentsThanaId { get; set; }

    public int? ParentsDistrictId { get; set; }

    public string? GuardianName { get; set; }

    public string? GuardianRelation { get; set; }

    public string? GuardianMobileNo { get; set; }

    public string? GuardianAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PermanentAddressBn { get; set; }

    public int? PermanentPostOfficeId { get; set; }

    public int? PermanentThanaId { get; set; }

    public int? PermanentDistrictId { get; set; }

    public string? PresentAddress { get; set; }

    public string? PresentAddressBn { get; set; }

    public int? PresentPostOfficeId { get; set; }

    public int? PresentThanaId { get; set; }

    public int? PresentDistrictId { get; set; }

    public string? PreScboard { get; set; }

    public int? PreScpassingYear { get; set; }

    public string? PreScregistration { get; set; }

    public long? PreScrollNo { get; set; }

    public double? PreScgpa { get; set; }

    public string? PreSchoolName { get; set; }

    public string? Tccollege { get; set; }

    public DateTime? Tcdate { get; set; }

    public string? ImageName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAppoved { get; set; }

    public DateTime? CreateOn { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AppovedBy { get; set; }

    public DateTime? AppovedTime { get; set; }

    public string? Note { get; set; }

    public string? MoneyReceiptNo { get; set; }

    public string? PreScboardHsc { get; set; }

    public int? PreScpassingYearHsc { get; set; }

    public string? PreScregistrationHsc { get; set; }

    public long? PreScrollNoHsc { get; set; }

    public double? PreScgpahsc { get; set; }

    public string? PreSchoolNameHsc { get; set; }

    public string? NuadmissionRoll { get; set; }

    public string? PreScboardHonours { get; set; }

    public int? PreScpassingYearHonours { get; set; }

    public string? PreScregistrationHonours { get; set; }

    public long? PreScrollNoHonours { get; set; }

    public double? PreScgpahonours { get; set; }

    public string? PreSchoolNameHonours { get; set; }

    public string? ManSubId { get; set; }

    public string? OpSubId { get; set; }
}
