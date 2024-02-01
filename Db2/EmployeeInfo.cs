using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class EmployeeInfo
{
    public long Eid { get; set; }

    public long? EcardNo { get; set; }

    public DateTime? EjoiningDate { get; set; }

    public string? Ename { get; set; }

    public string? TcodeNo { get; set; }

    public string? Egender { get; set; }

    public string? EfathersName { get; set; }

    public string? EmothersName { get; set; }

    public short? Did { get; set; }

    public short? DesId { get; set; }

    public string? Ereligion { get; set; }

    public string? EmaritalStatus { get; set; }

    public string? Ephone { get; set; }

    public string? Emobile { get; set; }

    public string? Eemail { get; set; }

    public DateTime? Ebirthday { get; set; }

    public string? EpresentAddress { get; set; }

    public string? EparmanentAddress { get; set; }

    public string? EbloodGroup { get; set; }

    public string? ElastDegree { get; set; }

    public bool? Eexaminer { get; set; }

    public string? Enationality { get; set; }

    public string? EpictureName { get; set; }

    public bool? IsActive { get; set; }

    public string? Estatus { get; set; }

    public string? Shift { get; set; }

    public short? ShiftId { get; set; }

    public bool? ForAllShift { get; set; }

    public bool? IsFaculty { get; set; }

    public bool? Vp { get; set; }

    public string? EnameBn { get; set; }

    public string? Ecname { get; set; }

    public string? Ecrelation { get; set; }

    public string? Ecmobile { get; set; }

    public string? Eoitraining { get; set; }

    public bool? Eoimsoffice { get; set; }

    public bool? EoidigitalContent { get; set; }

    public bool? Eoimmclass { get; set; }

    public bool? EoiaccessInt { get; set; }

    public int? EiiclassTeacher { get; set; }

    public int? Eiigroup { get; set; }

    public int? EiisubjectId { get; set; }

    public string? Eiixisection { get; set; }

    public string? Eiixiisection { get; set; }

    public string? EsignName { get; set; }

    public int? PrDistrict { get; set; }

    public int? PrThana { get; set; }

    public int? PrPostOffice { get; set; }

    public int? PerDistrict { get; set; }

    public int? PerThana { get; set; }

    public int? PerPostOffice { get; set; }

    public int? EmployeeTypeId { get; set; }

    public virtual ICollection<LeaveApplication> LeaveApplications { get; } = new List<LeaveApplication>();

    public virtual ICollection<Salaryset> Salarysets { get; } = new List<Salaryset>();

    public virtual ICollection<TblSubjectTeacher> TblSubjectTeachers { get; } = new List<TblSubjectTeacher>();
}
