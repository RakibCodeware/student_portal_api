using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EduPortalAPI.Db2;

public partial class VirtualDbContext2 : DbContext
{
    public VirtualDbContext2()
    {
    }

    public VirtualDbContext2(DbContextOptions<VirtualDbContext2> options)
        : base(options)
    {
    }

    public virtual DbSet<AbsentFine> AbsentFines { get; set; }

    public virtual DbSet<AccountsExpense> AccountsExpenses { get; set; }

    public virtual DbSet<AccountsIncome> AccountsIncomes { get; set; }

    public virtual DbSet<AccountsSetting> AccountsSettings { get; set; }

    public virtual DbSet<AccountsTitle> AccountsTitles { get; set; }

    public virtual DbSet<Acgroup> Acgroups { get; set; }

    public virtual DbSet<ActimeZone> ActimeZones { get; set; }

    public virtual DbSet<AcunlockComb> AcunlockCombs { get; set; }

    public virtual DbSet<AddCourseWithSubject> AddCourseWithSubjects { get; set; }

    public virtual DbSet<AlarmLog> AlarmLogs { get; set; }

    public virtual DbSet<AllowanceLog> AllowanceLogs { get; set; }

    public virtual DbSet<AllowanceType> AllowanceTypes { get; set; }

    public virtual DbSet<AttParam> AttParams { get; set; }

    public virtual DbSet<AttendanceCountType> AttendanceCountTypes { get; set; }

    public virtual DbSet<AttendanceSheetInfo> AttendanceSheetInfos { get; set; }

    public virtual DbSet<AttendanceStatus> AttendanceStatuses { get; set; }

    public virtual DbSet<AttendanceTransferMedium> AttendanceTransferMedia { get; set; }

    public virtual DbSet<AuditedExc> AuditedExcs { get; set; }

    public virtual DbSet<Authdevice> Authdevices { get; set; }

    public virtual DbSet<BatchInfo> BatchInfos { get; set; }

    public virtual DbSet<Board> Boards { get; set; }

    public virtual DbSet<Checkexact> Checkexacts { get; set; }

    public virtual DbSet<Checkinout> Checkinouts { get; set; }

    public virtual DbSet<Checkinoutonline> Checkinoutonlines { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassDegree2ndYearMarksSheet> ClassDegree2ndYearMarksSheets { get; set; }

    public virtual DbSet<ClassDegree2ndYearMarksSheetTotalResultProcess> ClassDegree2ndYearMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassDegree3rdYearMarksSheet> ClassDegree3rdYearMarksSheets { get; set; }

    public virtual DbSet<ClassDegree3rdYearMarksSheetTotalResultProcess> ClassDegree3rdYearMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassDegreeFirstYearMarksSheet> ClassDegreeFirstYearMarksSheets { get; set; }

    public virtual DbSet<ClassDegreeFirstYearMarksSheetTotalResultProcess> ClassDegreeFirstYearMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassDependencyPassMark> ClassDependencyPassMarks { get; set; }

    public virtual DbSet<ClassElevenBmtmarksSheet> ClassElevenBmtmarksSheets { get; set; }

    public virtual DbSet<ClassElevenBmtmarksSheetTotalResultProcess> ClassElevenBmtmarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassElevenMarksSheet> ClassElevenMarksSheets { get; set; }

    public virtual DbSet<ClassElevenMarksSheetTotalResultProcess> ClassElevenMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassHonoursFirstYearMarksSheet> ClassHonoursFirstYearMarksSheets { get; set; }

    public virtual DbSet<ClassHonoursFirstYearMarksSheetTotalResultProcess> ClassHonoursFirstYearMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassMastersFinalMarksSheet> ClassMastersFinalMarksSheets { get; set; }

    public virtual DbSet<ClassMastersFinalMarksSheetTotalResultProcess> ClassMastersFinalMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassPreliminaryToMastesMarksSheet> ClassPreliminaryToMastesMarksSheets { get; set; }

    public virtual DbSet<ClassPreliminaryToMastesMarksSheetTotalResultProcess> ClassPreliminaryToMastesMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassSubject> ClassSubjects { get; set; }

    public virtual DbSet<ClassTwelveBmtmarksSheet> ClassTwelveBmtmarksSheets { get; set; }

    public virtual DbSet<ClassTwelveBmtmarksSheetTotalResultProcess> ClassTwelveBmtmarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassTwelveMarksSheet> ClassTwelveMarksSheets { get; set; }

    public virtual DbSet<ClassTwelveMarksSheetTotalResultProcess> ClassTwelveMarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassXibmmarksSheet> ClassXibmmarksSheets { get; set; }

    public virtual DbSet<ClassXibmmarksSheetTotalResultProcess> ClassXibmmarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassXiibmmarksSheet> ClassXiibmmarksSheets { get; set; }

    public virtual DbSet<ClassXiibmmarksSheetTotalResultProcess> ClassXiibmmarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassXiimarksSheet> ClassXiimarksSheets { get; set; }

    public virtual DbSet<ClassXiimarksSheetTotalResultProcess> ClassXiimarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassXimarksSheet> ClassXimarksSheets { get; set; }

    public virtual DbSet<ClassXimarksSheetTotalResultProcess> ClassXimarksSheetTotalResultProcesses { get; set; }

    public virtual DbSet<ClassesAdmission> ClassesAdmissions { get; set; }

    public virtual DbSet<CurrentStudentInfo> CurrentStudentInfos { get; set; }

    public virtual DbSet<CurrentStudentLog> CurrentStudentLogs { get; set; }

    public virtual DbSet<DailyAttendanceRecord> DailyAttendanceRecords { get; set; }

    public virtual DbSet<DateOfPayment> DateOfPayments { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentsHr> DepartmentsHrs { get; set; }

    public virtual DbSet<DeptUsedSch> DeptUsedSchs { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Distritct> Distritcts { get; set; }

    public virtual DbSet<EmOpLog> EmOpLogs { get; set; }

    public virtual DbSet<EmployeeActivationLog> EmployeeActivationLogs { get; set; }

    public virtual DbSet<EmployeeEducation> EmployeeEducations { get; set; }

    public virtual DbSet<EmployeeExperience> EmployeeExperiences { get; set; }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    public virtual DbSet<EmployeeOthersInfo> EmployeeOthersInfos { get; set; }

    public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }

    public virtual DbSet<ExamDependencyInfo> ExamDependencyInfos { get; set; }

    public virtual DbSet<ExamExamRoutine> ExamExamRoutines { get; set; }

    public virtual DbSet<ExamExaminee> ExamExaminees { get; set; }

    public virtual DbSet<ExamFinalResultStockOfAllBatch> ExamFinalResultStockOfAllBatches { get; set; }

    public virtual DbSet<ExamInfo> ExamInfos { get; set; }

    public virtual DbSet<ExamResultFailSubject> ExamResultFailSubjects { get; set; }

    public virtual DbSet<ExamResultMeritList> ExamResultMeritLists { get; set; }

    public virtual DbSet<ExamResultSheet> ExamResultSheets { get; set; }

    public virtual DbSet<ExamType> ExamTypes { get; set; }

    public virtual DbSet<Excnote> Excnotes { get; set; }

    public virtual DbSet<FaceTemp> FaceTemps { get; set; }

    public virtual DbSet<FacultyStaffAttendanceSheetMarch2015> FacultyStaffAttendanceSheetMarch2015s { get; set; }

    public virtual DbSet<FeesCategoryInfo> FeesCategoryInfos { get; set; }

    public virtual DbSet<FeesCategoryPaymentForType> FeesCategoryPaymentForTypes { get; set; }

    public virtual DbSet<FinalResultLog> FinalResultLogs { get; set; }

    public virtual DbSet<FinePurposeEntry> FinePurposeEntries { get; set; }

    public virtual DbSet<FormsInfo> FormsInfos { get; set; }

    public virtual DbSet<Grading> Gradings { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<LeaveApplication> LeaveApplications { get; set; }

    public virtual DbSet<LeaveApplicationDetail> LeaveApplicationDetails { get; set; }

    public virtual DbSet<LeaveApplicationLog> LeaveApplicationLogs { get; set; }

    public virtual DbSet<LeaveClass> LeaveClasses { get; set; }

    public virtual DbSet<LeaveClass1> LeaveClass1s { get; set; }

    public virtual DbSet<LeaveConfiguration> LeaveConfigurations { get; set; }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<MachineAttendanceSheet> MachineAttendanceSheets { get; set; }

    public virtual DbSet<MarksInfo> MarksInfos { get; set; }

    public virtual DbSet<NagadPaymentLog> NagadPaymentLogs { get; set; }

    public virtual DbSet<NewSubject> NewSubjects { get; set; }

    public virtual DbSet<NumRun> NumRuns { get; set; }

    public virtual DbSet<NumRunDeil> NumRunDeils { get; set; }

    public virtual DbSet<OffdaySetting> OffdaySettings { get; set; }

    public virtual DbSet<PageInfo> PageInfos { get; set; }

    public virtual DbSet<ParticularsCategory> ParticularsCategories { get; set; }

    public virtual DbSet<ParticularsInfo> ParticularsInfos { get; set; }

    public virtual DbSet<PaymentErrorLog> PaymentErrorLogs { get; set; }

    public virtual DbSet<PaymentInfo> PaymentInfos { get; set; }

    public virtual DbSet<PaymentInfoDetail> PaymentInfoDetails { get; set; }

    public virtual DbSet<PaymentInfoIpnLog> PaymentInfoIpnLogs { get; set; }

    public virtual DbSet<PaymentInfoLog> PaymentInfoLogs { get; set; }

    public virtual DbSet<PaymentOpenStudentInfo> PaymentOpenStudentInfos { get; set; }

    public virtual DbSet<PaymentStore> PaymentStores { get; set; }

    public virtual DbSet<PeriodSetting> PeriodSettings { get; set; }

    public virtual DbSet<PostOffice> PostOffices { get; set; }

    public virtual DbSet<QuestionPattern> QuestionPatterns { get; set; }

    public virtual DbSet<ReportItem> ReportItems { get; set; }

    public virtual DbSet<ResultPublishedLog> ResultPublishedLogs { get; set; }

    public virtual DbSet<SalarySetLog> SalarySetLogs { get; set; }

    public virtual DbSet<Salaryset> Salarysets { get; set; }

    public virtual DbSet<SchClass> SchClasses { get; set; }

    public virtual DbSet<SchoolSetup> SchoolSetups { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Securitydetail> Securitydetails { get; set; }

    public virtual DbSet<ServerLog> ServerLogs { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<ShiftConfiguration> ShiftConfigurations { get; set; }

    public virtual DbSet<StudentAbsentDetail> StudentAbsentDetails { get; set; }

    public virtual DbSet<StudentActivationLog> StudentActivationLogs { get; set; }

    public virtual DbSet<StudentAdmissionFormInfo> StudentAdmissionFormInfos { get; set; }

    public virtual DbSet<StudentAttendance> StudentAttendances { get; set; }

    public virtual DbSet<StudentFailList> StudentFailLists { get; set; }

    public virtual DbSet<StudentFine> StudentFines { get; set; }

    public virtual DbSet<StudentFineSetting> StudentFineSettings { get; set; }

    public virtual DbSet<StudentGroupSubSetup> StudentGroupSubSetups { get; set; }

    public virtual DbSet<StudentGroupSubSetupDetail> StudentGroupSubSetupDetails { get; set; }

    public virtual DbSet<StudentGroupSubjectDetailsTemp> StudentGroupSubjectDetailsTemps { get; set; }

    public virtual DbSet<StudentGroupSubjectInfoTemp> StudentGroupSubjectInfoTemps { get; set; }

    public virtual DbSet<StudentPassingYearForAdmission> StudentPassingYearForAdmissions { get; set; }

    public virtual DbSet<StudentPayment> StudentPayments { get; set; }

    public virtual DbSet<SubjectQuestionPattern> SubjectQuestionPatterns { get; set; }

    public virtual DbSet<SystemLog> SystemLogs { get; set; }

    public virtual DbSet<Tbkey> Tbkeys { get; set; }

    public virtual DbSet<TblAdmDateOfPayment> TblAdmDateOfPayments { get; set; }

    public virtual DbSet<TblAdmFeesCategory> TblAdmFeesCategories { get; set; }

    public virtual DbSet<TblAdmParticularsCategory> TblAdmParticularsCategories { get; set; }

    public virtual DbSet<TblBuIldingName> TblBuIldingNames { get; set; }

    public virtual DbSet<TblBuildingWithRoom> TblBuildingWithRooms { get; set; }

    public virtual DbSet<TblBusInformation> TblBusInformations { get; set; }

    public virtual DbSet<TblClassGroup> TblClassGroups { get; set; }

    public virtual DbSet<TblClassRoutine> TblClassRoutines { get; set; }

    public virtual DbSet<TblClassSection> TblClassSections { get; set; }

    public virtual DbSet<TblClassTimeSpecification> TblClassTimeSpecifications { get; set; }

    public virtual DbSet<TblExamMonthlyTestDetail> TblExamMonthlyTestDetails { get; set; }

    public virtual DbSet<TblExamMontlyTest> TblExamMontlyTests { get; set; }

    public virtual DbSet<TblExamTimeSetName> TblExamTimeSetNames { get; set; }

    public virtual DbSet<TblExamTimeSettingsDetail> TblExamTimeSettingsDetails { get; set; }

    public virtual DbSet<TblExamTimeSettingsInfo> TblExamTimeSettingsInfos { get; set; }

    public virtual DbSet<TblExamTimeSpecification> TblExamTimeSpecifications { get; set; }

    public virtual DbSet<TblGroup> TblGroups { get; set; }

    public virtual DbSet<TblGuideTeacher> TblGuideTeachers { get; set; }

    public virtual DbSet<TblLocationInformation> TblLocationInformations { get; set; }

    public virtual DbSet<TblPhoneBook> TblPhoneBooks { get; set; }

    public virtual DbSet<TblPhoneGroup> TblPhoneGroups { get; set; }

    public virtual DbSet<TblPlaceInformation> TblPlaceInformations { get; set; }

    public virtual DbSet<TblSectionChangeLog> TblSectionChangeLogs { get; set; }

    public virtual DbSet<TblSession> TblSessions { get; set; }

    public virtual DbSet<TblSmsBody> TblSmsBodies { get; set; }

    public virtual DbSet<TblSmsReport> TblSmsReports { get; set; }

    public virtual DbSet<TblSmsTransactionLog> TblSmsTransactionLogs { get; set; }

    public virtual DbSet<TblStdAdmissionInfo> TblStdAdmissionInfos { get; set; }

    public virtual DbSet<TblStdType> TblStdTypes { get; set; }

    public virtual DbSet<TblSubjectTeacher> TblSubjectTeachers { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TblWeeklyDay> TblWeeklyDays { get; set; }

    public virtual DbSet<Tbsmsallot> Tbsmsallots { get; set; }

    public virtual DbSet<Tbsmsinfo> Tbsmsinfos { get; set; }

    public virtual DbSet<TeCategory> TeCategories { get; set; }

    public virtual DbSet<TeCommittee> TeCommittees { get; set; }

    public virtual DbSet<TeNumberPattern> TeNumberPatterns { get; set; }

    public virtual DbSet<TeNumberPatternDetail> TeNumberPatternDetails { get; set; }

    public virtual DbSet<TeNumberSheet> TeNumberSheets { get; set; }

    public virtual DbSet<TeSession> TeSessions { get; set; }

    public virtual DbSet<TeSubCategory> TeSubCategories { get; set; }

    public virtual DbSet<TeacherSubjectAllocation> TeacherSubjectAllocations { get; set; }

    public virtual DbSet<TempNewLeaveDateForAlter> TempNewLeaveDateForAlters { get; set; }

    public virtual DbSet<TempOldLeaveDateForAlter> TempOldLeaveDateForAlters { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<Thana> Thanas { get; set; }

    public virtual DbSet<TimingPeriod> TimingPeriods { get; set; }

    public virtual DbSet<UserAccontStudent> UserAccontStudents { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserAccountDetail> UserAccountDetails { get; set; }

    public virtual DbSet<UserAcmachine> UserAcmachines { get; set; }

    public virtual DbSet<UserAcprivilege> UserAcprivileges { get; set; }

    public virtual DbSet<UserOfRun> UserOfRuns { get; set; }

    public virtual DbSet<UserPrivilege> UserPrivileges { get; set; }

    public virtual DbSet<UserSpeday> UserSpedays { get; set; }

    public virtual DbSet<UserTempSch> UserTempSches { get; set; }

    public virtual DbSet<UserTypeInfo> UserTypeInfos { get; set; }

    public virtual DbSet<UserTypeInfoModulePrivilege> UserTypeInfoModulePrivileges { get; set; }

    public virtual DbSet<UserTypePageInfo> UserTypePageInfos { get; set; }

    public virtual DbSet<UserUpdate> UserUpdates { get; set; }

    public virtual DbSet<UserUsedSclass> UserUsedSclasses { get; set; }

    public virtual DbSet<Userinfo> Userinfos { get; set; }

    public virtual DbSet<UsersForPortal> UsersForPortals { get; set; }

    public virtual DbSet<UsersMachine> UsersMachines { get; set; }

    public virtual DbSet<VAccountsExpense> VAccountsExpenses { get; set; }

    public virtual DbSet<VAccountsIncome> VAccountsIncomes { get; set; }

    public virtual DbSet<VAdmFeesCatDetail> VAdmFeesCatDetails { get; set; }

    public virtual DbSet<VAdmPaymentReprint> VAdmPaymentReprints { get; set; }

    public virtual DbSet<VAdmStudentPaymentInfo> VAdmStudentPaymentInfos { get; set; }

    public virtual DbSet<VAdmissionStudent> VAdmissionStudents { get; set; }

    public virtual DbSet<VBatchInfo> VBatchInfos { get; set; }

    public virtual DbSet<VCheckStudentFine> VCheckStudentFines { get; set; }

    public virtual DbSet<VCheckinout> VCheckinouts { get; set; }

    public virtual DbSet<VClassGroupSection> VClassGroupSections { get; set; }

    public virtual DbSet<VClassSubjectCourseList> VClassSubjectCourseLists { get; set; }

    public virtual DbSet<VClassSubjectList> VClassSubjectLists { get; set; }

    public virtual DbSet<VClassSujectListForResultProcess> VClassSujectListForResultProcesses { get; set; }

    public virtual DbSet<VClasswiseSubject> VClasswiseSubjects { get; set; }

    public virtual DbSet<VCurrentStudentInfo> VCurrentStudentInfos { get; set; }

    public virtual DbSet<VCurrentStudentInfoForAttendance> VCurrentStudentInfoForAttendances { get; set; }

    public virtual DbSet<VDailyAbsentRecord> VDailyAbsentRecords { get; set; }

    public virtual DbSet<VDailyAttendanceRecordForReport> VDailyAttendanceRecordForReports { get; set; }

    public virtual DbSet<VDailyEmployeeAttendanceRecord> VDailyEmployeeAttendanceRecords { get; set; }

    public virtual DbSet<VDailyStudentAttendanceRecord> VDailyStudentAttendanceRecords { get; set; }

    public virtual DbSet<VDateOfPaymentDetail> VDateOfPaymentDetails { get; set; }

    public virtual DbSet<VDiscount> VDiscounts { get; set; }

    public virtual DbSet<VDiscountParticularDetail> VDiscountParticularDetails { get; set; }

    public virtual DbSet<VEmpDailyAbsentRecord> VEmpDailyAbsentRecords { get; set; }

    public virtual DbSet<VEmployeeInfo> VEmployeeInfos { get; set; }

    public virtual DbSet<VExamDependencyInfo> VExamDependencyInfos { get; set; }

    public virtual DbSet<VExamExaminee> VExamExaminees { get; set; }

    public virtual DbSet<VExamFailedAccordingToNumberOfSubject> VExamFailedAccordingToNumberOfSubjects { get; set; }

    public virtual DbSet<VExamFailedStudentReport> VExamFailedStudentReports { get; set; }

    public virtual DbSet<VExamInfo> VExamInfos { get; set; }

    public virtual DbSet<VExamResutlSummary> VExamResutlSummaries { get; set; }

    public virtual DbSet<VExamSubjectWiseResultAnalysis> VExamSubjectWiseResultAnalyses { get; set; }

    public virtual DbSet<VFeesCatDetail> VFeesCatDetails { get; set; }

    public virtual DbSet<VFinlaResultLog> VFinlaResultLogs { get; set; }

    public virtual DbSet<VGetFineStudentInfo> VGetFineStudentInfos { get; set; }

    public virtual DbSet<VGuideTeacher> VGuideTeachers { get; set; }

    public virtual DbSet<VLeaveApplication> VLeaveApplications { get; set; }

    public virtual DbSet<VLeaveApplicationLog> VLeaveApplicationLogs { get; set; }

    public virtual DbSet<VLeaveLeaveApplicationDetail> VLeaveLeaveApplicationDetails { get; set; }

    public virtual DbSet<VMoanthlyAttendanceSheetReport> VMoanthlyAttendanceSheetReports { get; set; }

    public virtual DbSet<VPhotoAlbum> VPhotoAlbums { get; set; }

    public virtual DbSet<VSalarySetDetail> VSalarySetDetails { get; set; }

    public virtual DbSet<VStudentAbsentDetail> VStudentAbsentDetails { get; set; }

    public virtual DbSet<VStudentGroupSubSetup> VStudentGroupSubSetups { get; set; }

    public virtual DbSet<VStudentGroupSubSetupDetail> VStudentGroupSubSetupDetails { get; set; }

    public virtual DbSet<VStudentMoneyReceipt> VStudentMoneyReceipts { get; set; }

    public virtual DbSet<VStudentPaymentDetail> VStudentPaymentDetails { get; set; }

    public virtual DbSet<VStudentPaymentInfo> VStudentPaymentInfos { get; set; }

    public virtual DbSet<VStudentWiseSubjectList> VStudentWiseSubjectLists { get; set; }

    public virtual DbSet<VSubjectQuestionPattern> VSubjectQuestionPatterns { get; set; }

    public virtual DbSet<VTblClassGroup> VTblClassGroups { get; set; }

    public virtual DbSet<VTblClassRoutine> VTblClassRoutines { get; set; }

    public virtual DbSet<VTblClassSection> VTblClassSections { get; set; }

    public virtual DbSet<VTblExamMonthlyTest> VTblExamMonthlyTests { get; set; }

    public virtual DbSet<VTeacherSubjectAllocation> VTeacherSubjectAllocations { get; set; }

    public virtual DbSet<VThanaDetail> VThanaDetails { get; set; }

    public virtual DbSet<VUserAccount> VUserAccounts { get; set; }

    public virtual DbSet<VUserAccountDetail> VUserAccountDetails { get; set; }

    public virtual DbSet<VUserAccountStudent> VUserAccountStudents { get; set; }

    public virtual DbSet<VUserPrivilege> VUserPrivileges { get; set; }

    public virtual DbSet<VUserTypeInfoModulePrivilege> VUserTypeInfoModulePrivileges { get; set; }

    public virtual DbSet<VUserTypePageInfoAccurateDatum> VUserTypePageInfoAccurateData { get; set; }

    public virtual DbSet<VUserTypePageInfoAllDatum> VUserTypePageInfoAllData { get; set; }

    public virtual DbSet<VVDailyAttendanceRecordForReport> VVDailyAttendanceRecordForReports { get; set; }

    public virtual DbSet<VVLeaveLeaveApplicationDetail> VVLeaveLeaveApplicationDetails { get; set; }

    public virtual DbSet<VVVLeaveLeaveApplicationDetailsForLeaveBalanceReport> VVVLeaveLeaveApplicationDetailsForLeaveBalanceReports { get; set; }

    public virtual DbSet<VVVLeaveYearlyStatus> VVVLeaveYearlyStatuses { get; set; }

    public virtual DbSet<VisitorCounter> VisitorCounters { get; set; }

    public virtual DbSet<Workstation> Workstations { get; set; }

    public virtual DbSet<WscommonSetting> WscommonSettings { get; set; }

    public virtual DbSet<Wsebook> Wsebooks { get; set; }

    public virtual DbSet<WseventInfo> WseventInfos { get; set; }

    public virtual DbSet<WseventInfoDetail> WseventInfoDetails { get; set; }

    public virtual DbSet<WsgalleryInfo> WsgalleryInfos { get; set; }

    public virtual DbSet<WsgalleryInfoDetail> WsgalleryInfoDetails { get; set; }

    public virtual DbSet<Wsnotice> Wsnotices { get; set; }

    public virtual DbSet<WsnoticeAttach> WsnoticeAttaches { get; set; }

    public virtual DbSet<Wspage> Wspages { get; set; }

    public virtual DbSet<WspageContent> WspageContents { get; set; }

    public virtual DbSet<WspresidentSpeech> WspresidentSpeeches { get; set; }

    public virtual DbSet<WsprincipalSpeech> WsprincipalSpeeches { get; set; }

    public virtual DbSet<Wsslider> Wssliders { get; set; }

    public virtual DbSet<WsspecialDescription> WsspecialDescriptions { get; set; }

    public virtual DbSet<YearInfo> YearInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=5.77.32.139; Initial catalog=cw_islampurCollege;User ID=cw_admin;Password=@CW#2018; Trusted_Connection=True; TrustServerCertificate=True;Integrated Security=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbsentFine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AbsentFine");

            entity.Property(e => e.Afid)
                .ValueGeneratedOnAdd()
                .HasColumnName("AFId");
            entity.Property(e => e.Date).HasColumnType("date");
        });

        modelBuilder.Entity<AccountsExpense>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Accounts_Expenses");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ExpensesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ExpensesID");
            entity.Property(e => e.Particular)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");

            entity.HasOne(d => d.Title).WithMany()
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Accounts_Expenses_Accounts_Title");
        });

        modelBuilder.Entity<AccountsIncome>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Accounts_Income");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.IncomeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IncomeID");
            entity.Property(e => e.Particular)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");

            entity.HasOne(d => d.Title).WithMany()
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Accounts_Income_Accounts_Title");
        });

        modelBuilder.Entity<AccountsSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Accounts_Setting");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccountsTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("Accounts_Title");

            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Acgroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__ACGroup__149AF30A1C8668BB");

            entity.ToTable("ACGroup");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("GroupID");
            entity.Property(e => e.Holidayvaild).HasColumnName("holidayvaild");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TimeZone1).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimeZone2).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimeZone3).HasDefaultValueSql("((0))");
            entity.Property(e => e.Verifystyle).HasColumnName("verifystyle");
        });

        modelBuilder.Entity<ActimeZone>(entity =>
        {
            entity.HasKey(e => e.TimeZoneId).HasName("PK__ACTimeZo__78D387CFFA8D4833");

            entity.ToTable("ACTimeZones");

            entity.Property(e => e.TimeZoneId)
                .ValueGeneratedNever()
                .HasColumnName("TimeZoneID");
            entity.Property(e => e.FriEnd).HasColumnType("datetime");
            entity.Property(e => e.FriStart).HasColumnType("datetime");
            entity.Property(e => e.MonEnd).HasColumnType("datetime");
            entity.Property(e => e.MonStart).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SatEnd).HasColumnType("datetime");
            entity.Property(e => e.SatStart).HasColumnType("datetime");
            entity.Property(e => e.SunEnd).HasColumnType("datetime");
            entity.Property(e => e.SunStart).HasColumnType("datetime");
            entity.Property(e => e.ThursEnd).HasColumnType("datetime");
            entity.Property(e => e.ThursStart).HasColumnType("datetime");
            entity.Property(e => e.TuesEnd).HasColumnType("datetime");
            entity.Property(e => e.TuesStart).HasColumnType("datetime");
            entity.Property(e => e.WedEnd).HasColumnType("datetime");
            entity.Property(e => e.WedStart).HasColumnType("datetime");
        });

        modelBuilder.Entity<AcunlockComb>(entity =>
        {
            entity.HasKey(e => e.UnlockCombId).HasName("PK__ACUnlock__1F6C4570CBBFB228");

            entity.ToTable("ACUnlockComb");

            entity.Property(e => e.UnlockCombId)
                .ValueGeneratedNever()
                .HasColumnName("UnlockCombID");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AddCourseWithSubject>(entity =>
        {
            entity.HasKey(e => e.CourseId);

            entity.ToTable("AddCourseWithSubject");

            entity.HasIndex(e => new { e.SubId, e.CourseName }, "uniqueComposite_SubId_CourseName").IsUnique();

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Sub).WithMany(p => p.AddCourseWithSubjects)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AddCourseWithSubject_NewSubject");
        });

        modelBuilder.Entity<AlarmLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AlarmLog__3214EC2725903AB4");

            entity.ToTable("AlarmLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EnrollNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LogTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MachineAlias)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AllowanceLog>(entity =>
        {
            entity.HasKey(e => e.Alid);

            entity.ToTable("AllowanceLog");

            entity.Property(e => e.Alid).HasColumnName("ALId");
            entity.Property(e => e.Aid).HasColumnName("AId");
            entity.Property(e => e.AlchangedBy).HasColumnName("ALChangedBy");
            entity.Property(e => e.Aldate)
                .HasColumnType("date")
                .HasColumnName("ALDate");
            entity.Property(e => e.AlnewPercentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALNewPercentage");
            entity.Property(e => e.AloldPercentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALOldPercentage");
        });

        modelBuilder.Entity<AllowanceType>(entity =>
        {
            entity.HasKey(e => e.Aid);

            entity.ToTable("AllowanceType");

            entity.Property(e => e.Aid).HasColumnName("AId");
            entity.Property(e => e.Apercentage).HasColumnName("APercentage");
            entity.Property(e => e.Astatus).HasColumnName("AStatus");
            entity.Property(e => e.Atype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AType");
        });

        modelBuilder.Entity<AttParam>(entity =>
        {
            entity.HasKey(e => e.Paraname).HasName("PK__AttParam__889D235F90BCDAE4");

            entity.ToTable("AttParam");

            entity.Property(e => e.Paraname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PARANAME");
            entity.Property(e => e.Paratype)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PARATYPE");
            entity.Property(e => e.Paravalue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PARAVALUE");
        });

        modelBuilder.Entity<AttendanceCountType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttendanceCountType");

            entity.Property(e => e.CountType)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttendanceSheetInfo>(entity =>
        {
            entity.ToTable("AttendanceSheetInfo");

            entity.Property(e => e.Asname)
                .HasMaxLength(70)
                .HasColumnName("ASName");
            entity.Property(e => e.Batch)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Section)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Year)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<AttendanceStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_Status");

            entity.Property(e => e.AttStatus)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttendanceTransferMedium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttDate).HasColumnType("date");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.StudentEmpAdmNo).HasColumnName("Student_Emp_AdmNo");
        });

        modelBuilder.Entity<AuditedExc>(entity =>
        {
            entity.HasKey(e => e.Aeid).HasName("PK__AuditedE__40737CF39C26F961");

            entity.ToTable("AuditedExc");

            entity.Property(e => e.Aeid).HasColumnName("AEID");
            entity.Property(e => e.CheckTime).HasColumnType("datetime");
            entity.Property(e => e.NewExcId).HasColumnName("NewExcID");
            entity.Property(e => e.Uname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UName");
            entity.Property(e => e.Utime)
                .HasColumnType("datetime")
                .HasColumnName("UTime");
        });

        modelBuilder.Entity<Authdevice>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.MachineId }).HasName("AUTHKEY");

            entity.ToTable("AUTHDEVICE");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.MachineId).HasColumnName("MachineID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<BatchInfo>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK_BatchInfo_1");

            entity.ToTable("BatchInfo");

            entity.HasIndex(e => e.BatchName, "BatchName_Unique").IsUnique();

            entity.Property(e => e.BatchName)
                .HasMaxLength(220)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
        });

        modelBuilder.Entity<Board>(entity =>
        {
            entity.HasKey(e => e.BoardId).HasName("PK_Boards_1");

            entity.HasIndex(e => e.BoardId, "Unique_BoardName").IsUnique();

            entity.Property(e => e.BoardName).HasMaxLength(30);
        });

        modelBuilder.Entity<Checkexact>(entity =>
        {
            entity.HasKey(e => e.Exactid).HasName("EXACTID");

            entity.ToTable("CHECKEXACT");

            entity.Property(e => e.Exactid).HasColumnName("EXACTID");
            entity.Property(e => e.Checktime)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.Incount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("INCOUNT");
            entity.Property(e => e.Isadd)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ISADD");
            entity.Property(e => e.Iscount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ISCOUNT");
            entity.Property(e => e.Isdelete)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ISDELETE");
            entity.Property(e => e.Ismodify)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ISMODIFY");
            entity.Property(e => e.Modifyby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('Temp-Supervisor')")
                .HasColumnName("MODIFYBY");
            entity.Property(e => e.Userid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("USERID");
            entity.Property(e => e.Yuyin)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("YUYIN");
        });

        modelBuilder.Entity<Checkinout>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Checktime }).HasName("USERCHECKTIME");

            entity.ToTable("CHECKINOUT");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Checktime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('I')")
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Memoinfo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sensorid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENSORID");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.UserExtFmt).HasDefaultValueSql("((0))");
            entity.Property(e => e.Verifycode)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VERIFYCODE");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Checkinoutonline>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Checktime }).HasName("USERCHECKTIME2");

            entity.ToTable("CHECKINOUTOnline");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Checktime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Badgenumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("BADGENUMBER");
            entity.Property(e => e.Checktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('I')")
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Memoinfo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sensorid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENSORID");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.UserExtFmt).HasDefaultValueSql("((0))");
            entity.Property(e => e.Verifycode)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VERIFYCODE");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasIndex(e => e.ClassName, "Unique_ClassName").IsUnique();

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClassDegree2ndYearMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_De__3B629B1FAA155880");

            entity.ToTable("Class_Degree2ndYearMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Batch__687E5358");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ClsSe__69727791");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Degr__ExId__678A2F1F");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ExInI__66960AE6");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Shift__6A669BCA");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Stude__65A1E6AD");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassDegree2ndYearMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__SubQP__6B5AC003");
        });

        modelBuilder.Entity<ClassDegree2ndYearMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_De__32151C4253539F6B");

            entity.ToTable("Class_Degree2ndYearMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Batch__701F7520");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ClsSe__71139959");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ExInI__6E372CAE");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Degr__QPId__73F00604");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Shift__7207BD92");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Stude__6F2B50E7");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassDegree2ndYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__SubId__72FBE1CB");
        });

        modelBuilder.Entity<ClassDegree3rdYearMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_De__3B629B1F1F3088E9");

            entity.ToTable("Class_Degree3rdYearMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Batch__6C19DA12");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ClsSe__6D0DFE4B");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Degr__ExId__6B25B5D9");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ExInI__6A3191A0");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Shift__6E022284");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Stude__693D6D67");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassDegree3rdYearMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__SubQP__6EF646BD");
        });

        modelBuilder.Entity<ClassDegree3rdYearMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_De__32151C42370CF396");

            entity.ToTable("Class_Degree3rdYearMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Batch__73BAFBDA");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ClsSe__74AF2013");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ExInI__71D2B368");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Degr__QPId__778B8CBE");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Shift__75A3444C");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Stude__72C6D7A1");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassDegree3rdYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__SubId__76976885");
        });

        modelBuilder.Entity<ClassDegreeFirstYearMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_De__3B629B1F64F45DF1");

            entity.ToTable("Class_DegreeFirstYearMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Batch__3AEC92D2");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ClsSe__3BE0B70B");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Degr__ExId__39F86E99");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ExInI__39044A60");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Shift__3CD4DB44");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Stude__38102627");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassDegreeFirstYearMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__SubQP__3DC8FF7D");
        });

        modelBuilder.Entity<ClassDegreeFirstYearMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_De__32151C427A77867D");

            entity.ToTable("Class_DegreeFirstYearMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Batch__428DB49A");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ClsSe__4381D8D3");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__ExInI__40A56C28");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Degr__QPId__465E457E");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Shift__4475FD0C");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__Stude__41999061");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassDegreeFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Deg__SubId__456A2145");
        });

        modelBuilder.Entity<ClassDependencyPassMark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Class_DependencyPassMarks");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsDepId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ClsDepID");
        });

        modelBuilder.Entity<ClassElevenBmtmarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_El__3B629B1F84B70618");

            entity.ToTable("Class_ElevenBMTMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Batch__22C00386");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ClsSe__23B427BF");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Elev__ExId__21CBDF4D");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ExInI__20D7BB14");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Shift__24A84BF8");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Stude__1FE396DB");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassElevenBmtmarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__SubQP__259C7031");
        });

        modelBuilder.Entity<ClassElevenBmtmarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_El__32151C42E05B8530");

            entity.ToTable("Class_ElevenBMTMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Batch__2A61254E");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ClsSe__2B554987");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ExInI__2878DCDC");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Elev__QPId__2E31B632");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Shift__2C496DC0");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Stude__296D0115");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassElevenBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__SubId__2D3D91F9");
        });

        modelBuilder.Entity<ClassElevenMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_El__3B629B1F4508F300");

            entity.ToTable("Class_ElevenMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Batch__006AEB82");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ClsSe__015F0FBB");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Elev__ExId__7F76C749");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ExInI__7E82A310");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Shift__025333F4");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Stude__7D8E7ED7");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassElevenMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__SubQP__0347582D");
        });

        modelBuilder.Entity<ClassElevenMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_El__32151C426C7A001E");

            entity.ToTable("Class_ElevenMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Batch__080C0D4A");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ClsSe__09003183");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__ExInI__0623C4D8");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Elev__QPId__0BDC9E2E");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Shift__09F455BC");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__Stude__0717E911");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassElevenMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Ele__SubId__0AE879F5");
        });

        modelBuilder.Entity<ClassHonoursFirstYearMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_Ho__3B629B1FFCD9282F");

            entity.ToTable("Class_HonoursFirstYearMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__Batch__7425102E");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__ClsSe__75193467");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hono__ExId__7330EBF5");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__ExInI__723CC7BC");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__Shift__760D58A0");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__Stude__7148A383");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassHonoursFirstYearMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__SubQP__77017CD9");
        });

        modelBuilder.Entity<ClassHonoursFirstYearMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_Ho__32151C42D81280C9");

            entity.ToTable("Class_HonoursFirstYearMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__Batch__7BC631F6");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__ClsSe__7CBA562F");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__ExInI__79DDE984");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hono__QPId__7F96C2DA");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__Shift__7DAE7A68");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__Stude__7AD20DBD");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassHonoursFirstYearMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Hon__SubId__7EA29EA1");
        });

        modelBuilder.Entity<ClassMastersFinalMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_Ma__3B629B1FB67F9F0E");

            entity.ToTable("Class_MastersFinalMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__Batch__407061FE");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__ClsSe__41648637");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mast__ExId__3F7C3DC5");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__ExInI__3E88198C");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__Shift__4258AA70");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__Stude__3D93F553");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassMastersFinalMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__SubQP__434CCEA9");
        });

        modelBuilder.Entity<ClassMastersFinalMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_Ma__32151C42FF767A74");

            entity.ToTable("Class_MastersFinalMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__Batch__481183C6");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__ClsSe__4905A7FF");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__ExInI__46293B54");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mast__QPId__4BE214AA");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__Shift__49F9CC38");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__Stude__471D5F8D");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassMastersFinalMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Mas__SubId__4AEDF071");
        });

        modelBuilder.Entity<ClassPreliminaryToMastesMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_Pr__3B629B1FD9C48385");

            entity.ToTable("Class_PreliminaryToMastesMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__Batch__79A8DF5A");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__ClsSe__7A9D0393");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Prel__ExId__78B4BB21");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__ExInI__77C096E8");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__Shift__7B9127CC");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__Stude__76CC72AF");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassPreliminaryToMastesMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__SubQP__7C854C05");
        });

        modelBuilder.Entity<ClassPreliminaryToMastesMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_Pr__32151C428153E0FB");

            entity.ToTable("Class_PreliminaryToMastesMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__Batch__014A0122");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__ClsSe__023E255B");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__ExInI__7F61B8B0");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Prel__QPId__051A9206");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__Shift__03324994");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__Stude__0055DCE9");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassPreliminaryToMastesMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Pre__SubId__04266DCD");
        });

        modelBuilder.Entity<ClassSubject>(entity =>
        {
            entity.HasKey(e => e.Csid);

            entity.ToTable("ClassSubject");

            entity.HasIndex(e => new { e.ClassId, e.SubId, e.CourseId, e.GroupId }, "ClassId_SubjectId_CourseId_GroupId_As_Unique").IsUnique();

            entity.Property(e => e.Csid).HasColumnName("CSId");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.GroupId).HasDefaultValueSql("((0))");
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Class).WithMany(p => p.ClassSubjects)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClassSubject_Classes");
        });

        modelBuilder.Entity<ClassTwelveBmtmarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_Tw__3B629B1F0A47BCA2");

            entity.ToTable("Class_TwelveBMTMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Batch__33EA8F88");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ClsSe__34DEB3C1");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twel__ExId__32F66B4F");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ExInI__32024716");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Shift__35D2D7FA");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Stude__310E22DD");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassTwelveBmtmarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__SubQP__36C6FC33");
        });

        modelBuilder.Entity<ClassTwelveBmtmarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_Tw__32151C423A82DB6E");

            entity.ToTable("Class_TwelveBMTMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Batch__3B8BB150");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ClsSe__3C7FD589");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ExInI__39A368DE");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twel__QPId__3F5C4234");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Shift__3D73F9C2");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Stude__3A978D17");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassTwelveBmtmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__SubId__3E681DFB");
        });

        modelBuilder.Entity<ClassTwelveMarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_Tw__3B629B1F4E4E7FBE");

            entity.ToTable("Class_TwelveMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Batch__11957784");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ClsSe__12899BBD");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twel__ExId__10A1534B");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ExInI__0FAD2F12");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Shift__137DBFF6");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Stude__0EB90AD9");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassTwelveMarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__SubQP__1471E42F");
        });

        modelBuilder.Entity<ClassTwelveMarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_Tw__32151C42012BEAEE");

            entity.ToTable("Class_TwelveMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Batch__1936994C");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ClsSe__1A2ABD85");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__ExInI__174E50DA");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twel__QPId__1D072A30");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Shift__1B1EE1BE");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__Stude__18427513");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassTwelveMarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_Twe__SubId__1C1305F7");
        });

        modelBuilder.Entity<ClassXibmmarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_XI__3B629B1FFD9E3518");

            entity.ToTable("Class_XIBMMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__Batch__5E15D37E");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__ClsSe__5F09F7B7");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIBM__ExId__5D21AF45");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__ExInI__5C2D8B0C");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__Shift__5FFE1BF0");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__Stude__5B3966D3");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassXibmmarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__SubQP__60F24029");
        });

        modelBuilder.Entity<ClassXibmmarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_XI__32151C4206B05514");

            entity.ToTable("Class_XIBMMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__Batch__65B6F546");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__ClsSe__66AB197F");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__ExInI__63CEACD4");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIBM__QPId__6987862A");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__Shift__679F3DB8");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__Stude__64C2D10D");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassXibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIB__SubId__689361F1");
        });

        modelBuilder.Entity<ClassXiibmmarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_XI__3B629B1FC5FBF52D");

            entity.ToTable("Class_XIIBMMarksSheet", "cw_admin");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Batch__6F405F80");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ClsSe__703483B9");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIIB__ExId__6E4C3B47");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ExInI__6D58170E");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Shift__7128A7F2");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Stude__6C63F2D5");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassXiibmmarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__SubQP__721CCC2B");
        });

        modelBuilder.Entity<ClassXiibmmarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_XI__32151C42CE2A3131");

            entity.ToTable("Class_XIIBMMarksSheet_TotalResultProcess", "cw_admin");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Batch__76E18148");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ClsSe__77D5A581");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ExInI__74F938D6");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIIB__QPId__7AB2122C");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Shift__78C9C9BA");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Stude__75ED5D0F");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassXiibmmarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__SubId__79BDEDF3");
        });

        modelBuilder.Entity<ClassXiimarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_XI__3B629B1F765BBB96");

            entity.ToTable("Class_XIIMarksSheet");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Batch__6FAA73D4");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ClsSe__709E980D");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIIM__ExId__6EB64F9B");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ExInI__6DC22B62");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Shift__7192BC46");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Stude__6CCE0729");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassXiimarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__SubQP__7286E07F");
        });

        modelBuilder.Entity<ClassXiimarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_XI__32151C428E0461E7");

            entity.ToTable("Class_XIIMarksSheet_TotalResultProcess");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Batch__774B959C");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ClsSe__783FB9D5");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__ExInI__75634D2A");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIIM__QPId__7B1C2680");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Shift__7933DE0E");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__Stude__76577163");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassXiimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XII__SubId__7A280247");
        });

        modelBuilder.Entity<ClassXimarksSheet>(entity =>
        {
            entity.HasKey(e => e.MarksSl).HasName("PK__Class_XI__3B629B1F4DD48CC3");

            entity.ToTable("Class_XIMarksSheet");

            entity.Property(e => e.MarksSl).HasColumnName("MarksSL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__Batch__5E7FE7D2");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__ClsSe__5F740C0B");

            entity.HasOne(d => d.Ex).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.ExId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIMa__ExId__5D8BC399");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__ExInI__5C979F60");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__Shift__60683044");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__Stude__5BA37B27");

            entity.HasOne(d => d.SubQp).WithMany(p => p.ClassXimarksSheets)
                .HasForeignKey(d => d.SubQpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__SubQP__615C547D");
        });

        modelBuilder.Entity<ClassXimarksSheetTotalResultProcess>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK__Class_XI__32151C425446A428");

            entity.ToTable("Class_XIMarksSheet_TotalResultProcess");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GradeOfAllPatternByScid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfAllPatternBySCId");
            entity.Property(e => e.GradeOfSubjectWithAllDependencySub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GradeOfSubject_WithAllDependencySub");
            entity.Property(e => e.MarksOfAllPatternByScid).HasColumnName("MarksOfAllPatternBySCId");
            entity.Property(e => e.MarksOfSubjectWithAllDependencySub).HasColumnName("MarksOfSubject_WithAllDependencySub");
            entity.Property(e => e.PointOfAllPatternByScid).HasColumnName("PointOfAllPatternBySCId");
            entity.Property(e => e.PointOfSubjectWithAllDependencySub).HasColumnName("PointOfSubject_WithAllDependencySub");
            entity.Property(e => e.Qpid).HasColumnName("QPId");

            entity.HasOne(d => d.Batch).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__Batch__6621099A");

            entity.HasOne(d => d.ClsSec).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ClsSecId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__ClsSe__67152DD3");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__ExInI__6438C128");

            entity.HasOne(d => d.Qp).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.Qpid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIMa__QPId__69F19A7E");

            entity.HasOne(d => d.Shift).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__Shift__6809520C");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__Stude__652CE561");

            entity.HasOne(d => d.Sub).WithMany(p => p.ClassXimarksSheetTotalResultProcesses)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Class_XIM__SubId__68FD7645");
        });

        modelBuilder.Entity<ClassesAdmission>(entity =>
        {
            entity.HasKey(e => new { e.ClassId, e.AdmissionYear });

            entity.ToTable("ClassesAdmission");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
        });

        modelBuilder.Entity<CurrentStudentInfo>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("CurrentStudentInfo");

            entity.HasIndex(e => e.AdmissionNo, "IX_CurrentStudentInfo").IsUnique();

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BusId).HasColumnName("BusID");
            entity.Property(e => e.CertifiedDate).HasColumnType("date");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FatherDesg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameBn).HasMaxLength(50);
            entity.Property(e => e.FatherOrg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FathersMobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FathersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FathersProfession)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FathersProfessionBn).HasMaxLength(100);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullNameBn).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.GuardianMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.GuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianRelation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HomePhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.IdCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherDesg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotherNameBn).HasMaxLength(50);
            entity.Property(e => e.MotherOrg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotherPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherTongue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MothersMoible)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MothersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MothersProfession)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MothersProfessionBn).HasMaxLength(100);
            entity.Property(e => e.Nationality)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Padistrict)
                .HasColumnType("text")
                .HasColumnName("PADistrict");
            entity.Property(e => e.PapostOffice)
                .HasColumnType("text")
                .HasColumnName("PAPostOffice");
            entity.Property(e => e.PapostOfficeId).HasColumnName("PAPostOfficeID");
            entity.Property(e => e.ParentsAddress).IsUnicode(false);
            entity.Property(e => e.Pathana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAThana");
            entity.Property(e => e.Pavillage)
                .HasColumnType("text")
                .HasColumnName("PAVillage");
            entity.Property(e => e.PavillageBn)
                .HasMaxLength(100)
                .HasColumnName("PAVillageBn");
            entity.Property(e => e.PdistrictId).HasColumnName("PDistrictId");
            entity.Property(e => e.PlaceId).HasColumnName("PlaceID");
            entity.Property(e => e.PreferredClass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PreviousExamType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreviousSchoolName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Pscboard)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PSCBoard");
            entity.Property(e => e.Pscgpa).HasColumnName("PSCGPA");
            entity.Property(e => e.Pscjscregistration)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PSCJSCRegistration");
            entity.Property(e => e.PscpassingYear).HasColumnName("PSCPassingYear");
            entity.Property(e => e.PscrollNo).HasColumnName("PSCRollNo");
            entity.Property(e => e.PthanaId).HasColumnName("PThanaId");
            entity.Property(e => e.Religion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Session)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sscroll).HasColumnName("SSCRoll");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tadistrict)
                .HasColumnType("text")
                .HasColumnName("TADistrict");
            entity.Property(e => e.TapostOffice)
                .HasColumnType("text")
                .HasColumnName("TAPostOffice");
            entity.Property(e => e.TapostOfficeId).HasColumnName("TAPostOfficeID");
            entity.Property(e => e.Tathana)
                .HasColumnType("text")
                .HasColumnName("TAThana");
            entity.Property(e => e.TaviIlage)
                .HasColumnType("text")
                .HasColumnName("TAViIlage");
            entity.Property(e => e.TaviIlageBn)
                .HasMaxLength(100)
                .HasColumnName("TAViIlageBn");
            entity.Property(e => e.Tcclass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TCClass");
            entity.Property(e => e.TccollegeName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TCCollegeName");
            entity.Property(e => e.Tcdate)
                .HasColumnType("date")
                .HasColumnName("TCDate");
            entity.Property(e => e.Tcsemister)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TCSemister");
            entity.Property(e => e.TdistrictId).HasColumnName("TDistrictId");
            entity.Property(e => e.TthanaId).HasColumnName("TThanaId");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CurrentStudentLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CurrentStudent_Log");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");

            entity.HasOne(d => d.Batch).WithMany()
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_CurrentStudent_Log_BatchInfo");

            entity.HasOne(d => d.Class).WithMany()
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CurrentStudent_Log_Classes");

            entity.HasOne(d => d.Config).WithMany()
                .HasForeignKey(d => d.ConfigId)
                .HasConstraintName("FK_CurrentStudent_Log_ShiftConfiguration");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CurrentStudent_Log_CurrentStudentInfo");
        });

        modelBuilder.Entity<DailyAttendanceRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyAttendanceRecord");

            entity.HasIndex(e => new { e.StudentId, e.Eid, e.AttDate }, "StudentId_EID_AttDate_As_Unique").IsUnique();

            entity.Property(e => e.AttDate).HasColumnType("date");
            entity.Property(e => e.AttManual)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.AttStatus)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DailyStartTimeAltCloseTime)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DailyStartTimeALT_CloseTime");
            entity.Property(e => e.Did)
                .HasComment("This field for just staff departmetn id .That is null for every student")
                .HasColumnName("DId");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.InHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DateOfPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DateOfPayment");

            entity.HasIndex(e => e.FeeCatId, "Unique_DateOfPayment").IsUnique();

            entity.Property(e => e.DateOfEnd).HasColumnType("date");
            entity.Property(e => e.DateOfPaymentId).ValueGeneratedOnAdd();
            entity.Property(e => e.DateOfStart).HasColumnType("date");

            entity.HasOne(d => d.FeeCat).WithOne()
                .HasForeignKey<DateOfPayment>(d => d.FeeCatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DateOfPayment_FeesCategoryInfo");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Deptid).HasName("DEPTID");

            entity.ToTable("DEPARTMENTS");

            entity.HasIndex(e => e.Deptname, "DEPTNAME");

            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Att)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ATT");
            entity.Property(e => e.AutoSchPlan).HasDefaultValueSql("((1))");
            entity.Property(e => e.DefaultSchId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Deptname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Holiday).HasDefaultValueSql("((1))");
            entity.Property(e => e.InLate).HasDefaultValueSql("((1))");
            entity.Property(e => e.InheritDeptRule).HasDefaultValueSql("((1))");
            entity.Property(e => e.InheritDeptSch).HasDefaultValueSql("((1))");
            entity.Property(e => e.InheritDeptSchClass).HasDefaultValueSql("((1))");
            entity.Property(e => e.InheritParentSch).HasDefaultValueSql("((1))");
            entity.Property(e => e.MinAutoSchInterval).HasDefaultValueSql("((24))");
            entity.Property(e => e.OutEarly).HasDefaultValueSql("((1))");
            entity.Property(e => e.OverTime).HasDefaultValueSql("((1))");
            entity.Property(e => e.RegisterOt)
                .HasDefaultValueSql("((1))")
                .HasColumnName("RegisterOT");
            entity.Property(e => e.Supdeptid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SUPDEPTID");
        });

        modelBuilder.Entity<DepartmentsHr>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK_Department");

            entity.ToTable("Departments_HR");

            entity.HasIndex(e => e.Dname, "Unique_Departments").IsUnique();

            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
        });

        modelBuilder.Entity<DeptUsedSch>(entity =>
        {
            entity.HasKey(e => new { e.DeptId, e.SchId }).HasName("DEPT_USED_SCH");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesId);

            entity.HasIndex(e => e.DesName, "Unique_Designations").IsUnique();

            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Discount");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.Did)
                .ValueGeneratedOnAdd()
                .HasColumnName("DId");
            entity.Property(e => e.Discount1).HasColumnName("Discount");
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

            entity.HasOne(d => d.PidNavigation).WithMany()
                .HasForeignKey(d => d.Pid)
                .HasConstraintName("FK_Discount_ParticularsInfo");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Discount_StudentProfile");
        });

        modelBuilder.Entity<Distritct>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.HasIndex(e => e.DistrictName, "Unique_Distritcts").IsUnique();

            entity.Property(e => e.DistrictName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistrictNameBn).HasMaxLength(50);
        });

        modelBuilder.Entity<EmOpLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmOpLog");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ManipulationId).HasColumnName("manipulationID");
            entity.Property(e => e.OperateTime).HasColumnType("datetime");
            entity.Property(e => e.SensorId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<EmployeeActivationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeActivation_Log");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Note)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<EmployeeEducation>(entity =>
        {
            entity.HasKey(e => e.Slno).HasName("PK__Employee__A43D2D5CB5BD4025");

            entity.ToTable("EmployeeEducation");

            entity.Property(e => e.Slno).HasColumnName("SLNo");
            entity.Property(e => e.Eiboard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EIBoard");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Eidepertment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EIDepertment");
            entity.Property(e => e.EiexamName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EIExamName");
            entity.Property(e => e.EipassingYear).HasColumnName("EIPassingYear");
            entity.Property(e => e.Eiresult)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EIResult");
        });

        modelBuilder.Entity<EmployeeExperience>(entity =>
        {
            entity.HasKey(e => e.Slno).HasName("PK__Employee__A43D2D5C2ADF2A90");

            entity.ToTable("EmployeeExperience");

            entity.Property(e => e.Slno).HasColumnName("SLNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.ExIdateTo)
                .HasColumnType("date")
                .HasColumnName("ExIDateTO");
            entity.Property(e => e.ExIddateFrom)
                .HasColumnType("date")
                .HasColumnName("ExIDDateFrom");
            entity.Property(e => e.ExIdesignation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExIDesignation");
            entity.Property(e => e.ExIduration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExIDuration");
            entity.Property(e => e.ExIinstName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ExIInstName");
        });

        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.Eid);

            entity.ToTable("EmployeeInfo");

            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Ebirthday)
                .HasColumnType("date")
                .HasColumnName("EBirthday");
            entity.Property(e => e.EbloodGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EBloodGroup");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Ecmobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ECMobile");
            entity.Property(e => e.Ecname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ECName");
            entity.Property(e => e.Ecrelation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ECRelation");
            entity.Property(e => e.Eemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EEmail");
            entity.Property(e => e.Eexaminer).HasColumnName("EExaminer");
            entity.Property(e => e.EfathersName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFathersName");
            entity.Property(e => e.Egender)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("EGender");
            entity.Property(e => e.EiiclassTeacher).HasColumnName("EIIClassTeacher");
            entity.Property(e => e.Eiigroup).HasColumnName("EIIGroup");
            entity.Property(e => e.EiisubjectId).HasColumnName("EIISubjectId");
            entity.Property(e => e.Eiixiisection)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EIIXIISection");
            entity.Property(e => e.Eiixisection)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EIIXISection");
            entity.Property(e => e.EjoiningDate)
                .HasColumnType("date")
                .HasColumnName("EJoiningDate");
            entity.Property(e => e.ElastDegree)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ELastDegree");
            entity.Property(e => e.EmaritalStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMaritalStatus");
            entity.Property(e => e.Emobile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EMobile");
            entity.Property(e => e.EmothersName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMothersName");
            entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.EnameBn)
                .HasMaxLength(200)
                .HasColumnName("ENameBN");
            entity.Property(e => e.Enationality)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENationality");
            entity.Property(e => e.EoiaccessInt).HasColumnName("EOIAccessInt");
            entity.Property(e => e.EoidigitalContent).HasColumnName("EOIDigitalContent");
            entity.Property(e => e.Eoimmclass).HasColumnName("EOIMMClass");
            entity.Property(e => e.Eoimsoffice).HasColumnName("EOIMSOffice");
            entity.Property(e => e.Eoitraining)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EOITraining");
            entity.Property(e => e.EparmanentAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EParmanentAddress");
            entity.Property(e => e.Ephone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EPhone");
            entity.Property(e => e.EpictureName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("EPictureName");
            entity.Property(e => e.EpresentAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EPresentAddress");
            entity.Property(e => e.Ereligion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EReligion");
            entity.Property(e => e.EsignName)
                .HasMaxLength(1000)
                .HasColumnName("ESignName");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EStatus");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TcodeNo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TCodeNo");
            entity.Property(e => e.Vp).HasColumnName("VP");
        });

        modelBuilder.Entity<EmployeeOthersInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeOthersInfo");

            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.OthersInfo)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.EidNavigation).WithMany()
                .HasForeignKey(d => d.Eid)
                .HasConstraintName("FK_EmployeeOthersInfo_EmployeeInfo");
        });

        modelBuilder.Entity<EmployeeType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeType");

            entity.Property(e => e.EmployeeType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeType");
            entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");
        });

        modelBuilder.Entity<ExamDependencyInfo>(entity =>
        {
            entity.HasKey(e => e.DeId);

            entity.ToTable("ExamDependencyInfo");

            entity.Property(e => e.DependencyIexamId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DependencyIExamId");
            entity.Property(e => e.ParentExInId)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ParentExIn).WithMany(p => p.ExamDependencyInfos)
                .HasForeignKey(d => d.ParentExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ExamDependencyInfo_ExamInfo");
        });

        modelBuilder.Entity<ExamExamRoutine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Exam_ExamRoutine");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BuildingId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BuildingID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.ExamDate).HasColumnType("date");
            entity.Property(e => e.ExamDay)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.ExamRoutineId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ExamRoutineID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.SubId).HasColumnName("SubID");
        });

        modelBuilder.Entity<ExamExaminee>(entity =>
        {
            entity.HasKey(e => new { e.ExamId, e.StudentId });

            entity.ToTable("ExamExaminee");

            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ExamineeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ExamineeID");
        });

        modelBuilder.Entity<ExamFinalResultStockOfAllBatch>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_Exam_Result_Stock_Off_All_Batch");

            entity.ToTable("Exam_Final_Result_Stock_Of_All_Batch");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FinalGpaOfExam).HasColumnName("FinalGPA_OfExam");
            entity.Property(e => e.FinalGpaOfExamWithOptionalSub).HasColumnName("FinalGPA_OfExam_WithOptionalSub");
            entity.Property(e => e.FinalGradOfExam)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FinalGrad_OfExam");
            entity.Property(e => e.FinalGradeOfExamWithOptionalSub)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FinalGrade_OfExam_WithOptionalSub");
            entity.Property(e => e.FinalTotalMarksOfExam).HasColumnName("FinalTotalMarks_OfExam");
            entity.Property(e => e.FinalTotalMarksOfExamWithOptionalSub).HasColumnName("FinalTotalMarks_OfExam_WithOptionalSub");
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExamInfo>(entity =>
        {
            entity.HasKey(e => e.ExInId);

            entity.ToTable("ExamInfo");

            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExEndDate).HasColumnType("date");
            entity.Property(e => e.ExInSl).ValueGeneratedOnAdd();
            entity.Property(e => e.ExName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExStartDate).HasColumnType("date");
        });

        modelBuilder.Entity<ExamResultFailSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Exam_ResultFailSubject");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.SubId).HasColumnName("SubID");

            entity.HasOne(d => d.Result).WithMany()
                .HasPrincipalKey(p => p.Sl)
                .HasForeignKey(d => d.ResultId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Exam_ResultFailSubject_Exam_ResultSheet");
        });

        modelBuilder.Entity<ExamResultMeritList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Exam_ResultMeritList");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<ExamResultSheet>(entity =>
        {
            entity.HasKey(e => new { e.ExamId, e.StudentId });

            entity.ToTable("Exam_ResultSheet");

            entity.HasIndex(e => e.Sl, "IX_Exam_ResultSheet").IsUnique();

            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.AbsentSubjectCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FailAbsentSubjectCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FailSubjectCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gpa).HasColumnName("GPA");
            entity.Property(e => e.Grade)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.WithoutOpGpa).HasColumnName("withoutOpGPA");
            entity.Property(e => e.WithoutOpGrade)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("withoutOpGrade");
            entity.Property(e => e.WithoutOpTotalMarks).HasColumnName("withoutOpTotalMarks");

            entity.HasOne(d => d.ExIn).WithMany(p => p.ExamResultSheets)
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Exam_ResultSheet_ExamInfo");
        });

        modelBuilder.Entity<ExamType>(entity =>
        {
            entity.HasKey(e => e.ExId).HasName("PK_Exam");

            entity.ToTable("ExamType");

            entity.HasIndex(e => e.ExName, "Unique_Exam").IsUnique();

            entity.Property(e => e.ExName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Excnote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EXCNOTES");

            entity.HasIndex(e => new { e.Userid, e.Attdate }, "EXCNOTE").IsUnique();

            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDATE");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<FaceTemp>(entity =>
        {
            entity.HasKey(e => e.Templateid).HasName("PK__FaceTemp__9EE4AD533C971F81");

            entity.ToTable("FaceTemp");

            entity.HasIndex(e => e.Faceid, "FACEID");

            entity.HasIndex(e => e.Templateid, "TEMPLATEID");

            entity.HasIndex(e => e.Userno, "USERNO");

            entity.HasIndex(e => e.Valid, "VALID");

            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Activetime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACTIVETIME");
            entity.Property(e => e.Faceid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FACEID");
            entity.Property(e => e.Pin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pin");
            entity.Property(e => e.Reserve)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RESERVE");
            entity.Property(e => e.Size)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SIZE");
            entity.Property(e => e.Template)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("UserID");
            entity.Property(e => e.Userno)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("USERNO");
            entity.Property(e => e.Valid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VALID");
            entity.Property(e => e.Vfcount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VFCOUNT");
        });

        modelBuilder.Entity<FacultyStaffAttendanceSheetMarch2015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Faculty_Staff_AttendanceSheet_March2015");

            entity.Property(e => e.D1032015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D10_3_2015");
            entity.Property(e => e.D1132015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D11_3_2015");
            entity.Property(e => e.D1232015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D12_3_2015");
            entity.Property(e => e.D132015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D1_3_2015");
            entity.Property(e => e.D1332015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D13_3_2015");
            entity.Property(e => e.D1432015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D14_3_2015");
            entity.Property(e => e.D1532015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D15_3_2015");
            entity.Property(e => e.D1632015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D16_3_2015");
            entity.Property(e => e.D1732015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D17_3_2015");
            entity.Property(e => e.D1832015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D18_3_2015");
            entity.Property(e => e.D1932015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D19_3_2015");
            entity.Property(e => e.D2032015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D20_3_2015");
            entity.Property(e => e.D2132015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D21_3_2015");
            entity.Property(e => e.D2232015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D22_3_2015");
            entity.Property(e => e.D232015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D2_3_2015");
            entity.Property(e => e.D2332015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D23_3_2015");
            entity.Property(e => e.D2432015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D24_3_2015");
            entity.Property(e => e.D2532015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D25_3_2015");
            entity.Property(e => e.D2632015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D26_3_2015");
            entity.Property(e => e.D2732015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D27_3_2015");
            entity.Property(e => e.D2832015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D28_3_2015");
            entity.Property(e => e.D2932015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D29_3_2015");
            entity.Property(e => e.D3032015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D30_3_2015");
            entity.Property(e => e.D3132015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D31_3_2015");
            entity.Property(e => e.D332015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D3_3_2015");
            entity.Property(e => e.D432015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D4_3_2015");
            entity.Property(e => e.D532015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D5_3_2015");
            entity.Property(e => e.D632015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D6_3_2015");
            entity.Property(e => e.D732015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D7_3_2015");
            entity.Property(e => e.D832015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D8_3_2015");
            entity.Property(e => e.D932015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D9_3_2015");
            entity.Property(e => e.Eid).HasColumnName("EID");

            entity.HasOne(d => d.EidNavigation).WithMany()
                .HasForeignKey(d => d.Eid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Faculty_Sta__EID__36470DEF");
        });

        modelBuilder.Entity<FeesCategoryInfo>(entity =>
        {
            entity.HasKey(e => e.FeeCatId).HasName("PK_FeeCatInfo");

            entity.ToTable("FeesCategoryInfo");

            entity.Property(e => e.DateOfCreation).HasColumnType("date");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaymentFor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StoreNameKey)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FeesCategoryPaymentForType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FeesCategoryPaymentForInfo");

            entity.ToTable("FeesCategoryPaymentForType");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentFor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FinalResultLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FinalResultLog");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gpa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GPA");
            entity.Property(e => e.Grade)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Sgrade)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SGrade");
            entity.Property(e => e.Shift)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Spoint).HasColumnName("SPoint");
            entity.Property(e => e.TotalMarks)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.ExIn).WithMany()
                .HasForeignKey(d => d.ExInId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinalResultLog_ExamInfo");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinalResultLog_StudentProfile");

            entity.HasOne(d => d.Sub).WithMany()
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinalResultLog_NewSubject");
        });

        modelBuilder.Entity<FinePurposeEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FinePurposeEntry");

            entity.Property(e => e.FinePurpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fpid)
                .ValueGeneratedOnAdd()
                .HasColumnName("FPId");
        });

        modelBuilder.Entity<FormsInfo>(entity =>
        {
            entity.HasKey(e => e.FormsId);

            entity.ToTable("FormsInfo");

            entity.HasIndex(e => e.FormsName, "Unique_FormsInfo").IsUnique();

            entity.Property(e => e.FormsName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Grading>(entity =>
        {
            entity.HasKey(e => e.Gid);

            entity.ToTable("Grading");

            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GmarkMax).HasColumnName("GMarkMax");
            entity.Property(e => e.GmarkMin).HasColumnName("GMarkMin");
            entity.Property(e => e.Gname)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GpointMax).HasColumnName("GPointMax");
            entity.Property(e => e.GpointMin).HasColumnName("GPointMin");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.Holidayid).HasName("HOLID");

            entity.ToTable("HOLIDAYS");

            entity.HasIndex(e => e.Holidayname, "HOLIDAYNAME").IsUnique();

            entity.Property(e => e.Holidayid).HasColumnName("HOLIDAYID");
            entity.Property(e => e.DeptId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DeptID");
            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.Holidayday)
                .HasDefaultValueSql("((1))")
                .HasColumnName("HOLIDAYDAY");
            entity.Property(e => e.Holidaymonth).HasColumnName("HOLIDAYMONTH");
            entity.Property(e => e.Holidayname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HOLIDAYNAME");
            entity.Property(e => e.Holidaytype).HasColumnName("HOLIDAYTYPE");
            entity.Property(e => e.Holidayyear).HasColumnName("HOLIDAYYEAR");
            entity.Property(e => e.Minzu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MINZU");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("STARTTIME");
            entity.Property(e => e.Timezone)
                .HasDefaultValueSql("((0))")
                .HasColumnName("timezone");
            entity.Property(e => e.Xinbie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("XINBIE");
        });

        modelBuilder.Entity<LeaveApplication>(entity =>
        {
            entity.HasKey(e => e.Lacode);

            entity.ToTable("Leave_Application");

            entity.HasIndex(e => e.Lacode, "Leave_Application_FromDate_EId_CompositeUniqueKey").IsUnique();

            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.PrasaberaDate).HasColumnType("date");
            entity.Property(e => e.PregnantDate).HasColumnType("date");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("date");

            entity.HasOne(d => d.EidNavigation).WithMany(p => p.LeaveApplications)
                .HasForeignKey(d => d.Eid)
                .HasConstraintName("FK_Leave_Application_EmployeeInfo");
        });

        modelBuilder.Entity<LeaveApplicationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_Application_Details");

            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveDate).HasColumnType("date");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.LacodeNavigation).WithMany()
                .HasForeignKey(d => d.Lacode)
                .HasConstraintName("FK_Leave_Application_Details_Leave_Application");
        });

        modelBuilder.Entity<LeaveApplicationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_Application_Log");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedRejected)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.PrasaberaDate).HasColumnType("date");
            entity.Property(e => e.PregnantDate).HasColumnType("date");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("date");
        });

        modelBuilder.Entity<LeaveClass>(entity =>
        {
            entity.HasKey(e => e.LeaveId).HasName("PK__LeaveCla__796DB959366A6517");

            entity.ToTable("LeaveClass");

            entity.Property(e => e.LeaveName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MinUnit).HasDefaultValueSql("((1))");
            entity.Property(e => e.RemaindCount).HasDefaultValueSql("((1))");
            entity.Property(e => e.RemaindProc).HasDefaultValueSql("((1))");
            entity.Property(e => e.ReportSymbol)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')");
            entity.Property(e => e.Unit).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<LeaveClass1>(entity =>
        {
            entity.HasKey(e => e.LeaveId).HasName("PK__LeaveCla__796DB959068EBE37");

            entity.ToTable("LeaveClass1");

            entity.Property(e => e.Calc).HasColumnType("text");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MinUnit).HasDefaultValueSql("((1))");
            entity.Property(e => e.RemaindCount).HasDefaultValueSql("((1))");
            entity.Property(e => e.RemaindProc).HasDefaultValueSql("((2))");
            entity.Property(e => e.ReportSymbol)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')");
        });

        modelBuilder.Entity<LeaveConfiguration>(entity =>
        {
            entity.HasKey(e => e.LeaveId);

            entity.ToTable("leave_configuration");

            entity.HasIndex(e => e.LeaveName, "IX_leave_configuration").IsUnique();

            entity.HasIndex(e => e.LeaveName, "LeaveName_unique").IsUnique();

            entity.Property(e => e.LeaveName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LeaveNature)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Machines__3214EC27F4E63CED");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommPassword)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DateFormat).HasDefaultValueSql("((-1))");
            entity.Property(e => e.Fingercount)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("fingercount");
            entity.Property(e => e.FirmwareVersion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Idle).HasDefaultValueSql("((-1))");
            entity.Property(e => e.InOutRecordWarn).HasDefaultValueSql("((-1))");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.IsAndroid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.IsIfChangeConfigServer2).HasDefaultValueSql("((0))");
            entity.Property(e => e.LockControl).HasDefaultValueSql("((-1))");
            entity.Property(e => e.MachineAlias)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MachineNumber).HasDefaultValueSql("((1))");
            entity.Property(e => e.Managercount)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("managercount");
            entity.Property(e => e.PhotoStamp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Port).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProduceKind).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Purpose).HasDefaultValueSql("((1))");
            entity.Property(e => e.SecretCount).HasDefaultValueSql("((-1))");
            entity.Property(e => e.SerialPort).HasDefaultValueSql("((1))");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.Uilanguage)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("UILanguage");
            entity.Property(e => e.Usercount)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("usercount");
            entity.Property(e => e.Voice).HasDefaultValueSql("((-1))");
        });

        modelBuilder.Entity<MachineAttendanceSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Machine_AttendanceSheet");

            entity.Property(e => e.D1012015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D10_1_2015");
            entity.Property(e => e.D1112015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D11_1_2015");
            entity.Property(e => e.D112015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D1_1_2015");
            entity.Property(e => e.D1212015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D12_1_2015");
            entity.Property(e => e.D1312015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D13_1_2015");
            entity.Property(e => e.D1412015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D14_1_2015");
            entity.Property(e => e.D1512015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D15_1_2015");
            entity.Property(e => e.D1612015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D16_1_2015");
            entity.Property(e => e.D1712015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D17_1_2015");
            entity.Property(e => e.D1812015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D18_1_2015");
            entity.Property(e => e.D1912015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D19_1_2015");
            entity.Property(e => e.D2012015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D20_1_2015");
            entity.Property(e => e.D2112015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D21_1_2015");
            entity.Property(e => e.D212015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D2_1_2015");
            entity.Property(e => e.D2212015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D22_1_2015");
            entity.Property(e => e.D2312015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D23_1_2015");
            entity.Property(e => e.D2412015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D24_1_2015");
            entity.Property(e => e.D2512015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D25_1_2015");
            entity.Property(e => e.D2612015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D26_1_2015");
            entity.Property(e => e.D2712015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D27_1_2015");
            entity.Property(e => e.D2812015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D28_1_2015");
            entity.Property(e => e.D2912015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D29_1_2015");
            entity.Property(e => e.D3012015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D30_1_2015");
            entity.Property(e => e.D3112015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D31_1_2015");
            entity.Property(e => e.D312015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D3_1_2015");
            entity.Property(e => e.D412015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D4_1_2015");
            entity.Property(e => e.D512015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D5_1_2015");
            entity.Property(e => e.D612015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D6_1_2015");
            entity.Property(e => e.D712015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D7_1_2015");
            entity.Property(e => e.D812015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D8_1_2015");
            entity.Property(e => e.D912015)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("D9_1_2015");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Machine_A__Stude__3BFFE745");
        });

        modelBuilder.Entity<MarksInfo>(entity =>
        {
            entity.HasKey(e => e.Mid);

            entity.ToTable("MarksInfo");

            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.ExInId).HasMaxLength(50);
        });

        modelBuilder.Entity<NagadPaymentLog>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("NagadPayment_log");

            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrderID");
        });

        modelBuilder.Entity<NewSubject>(entity =>
        {
            entity.HasKey(e => e.SubId);

            entity.ToTable("NewSubject");

            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NumRun>(entity =>
        {
            entity.HasKey(e => e.NumRunid).HasName("NUMID");

            entity.ToTable("NUM_RUN");

            entity.Property(e => e.NumRunid).HasColumnName("NUM_RUNID");
            entity.Property(e => e.Cyle)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CYLE");
            entity.Property(e => e.Enddate)
                .HasDefaultValueSql("('2099-12-31')")
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Oldid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("OLDID");
            entity.Property(e => e.Startdate)
                .HasDefaultValueSql("('1900-1-1')")
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Units)
                .HasDefaultValueSql("((1))")
                .HasColumnName("UNITS");
        });

        modelBuilder.Entity<NumRunDeil>(entity =>
        {
            entity.HasKey(e => new { e.NumRunid, e.Sdays, e.Starttime }).HasName("NUMID2");

            entity.ToTable("NUM_RUN_DEIL");

            entity.Property(e => e.NumRunid).HasColumnName("NUM_RUNID");
            entity.Property(e => e.Sdays).HasColumnName("SDAYS");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("STARTTIME");
            entity.Property(e => e.Edays).HasColumnName("EDAYS");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("ENDTIME");
            entity.Property(e => e.Schclassid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SCHCLASSID");
        });

        modelBuilder.Entity<OffdaySetting>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.OffDate, e.ShiftId }, "Unq_OffDate").IsUnique();

            entity.Property(e => e.DayName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Month)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.OffDate).HasColumnType("date");
            entity.Property(e => e.OffDateId).ValueGeneratedOnAdd();
            entity.Property(e => e.Purpose)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<PageInfo>(entity =>
        {
            entity.HasKey(e => e.PageNameId);

            entity.ToTable("PageInfo");

            entity.HasIndex(e => e.PageName, "IX_PageInfo").IsUnique();

            entity.Property(e => e.Chosen).HasDefaultValueSql("((0))");
            entity.Property(e => e.ModuleType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ParticularsCategory>(entity =>
        {
            entity.HasKey(e => e.CatPid).HasName("PK_CatParticulars");

            entity.ToTable("ParticularsCategory");

            entity.Property(e => e.CatPid).HasColumnName("CatPId");
            entity.Property(e => e.Pid).HasColumnName("PId");

            entity.HasOne(d => d.FeeCat).WithMany(p => p.ParticularsCategories)
                .HasForeignKey(d => d.FeeCatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ParticularsCategory_FeesCategoryInfo");

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.ParticularsCategories)
                .HasForeignKey(d => d.Pid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ParticularsCategory_ParticularsInfo");
        });

        modelBuilder.Entity<ParticularsInfo>(entity =>
        {
            entity.HasKey(e => e.Pid);

            entity.ToTable("ParticularsInfo");

            entity.HasIndex(e => e.Pname, "Unique_ParticularsInfo").IsUnique();

            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<PaymentErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentError_log");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ErrorMsg).IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PaymentInfo>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_cw_payment_info");

            entity.ToTable("PaymentInfo");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClientMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("clientMobileNo");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.IssuerPaymentDateTime)
                .HasColumnType("datetime")
                .HasColumnName("issuerPaymentDateTime");
            entity.Property(e => e.IssuerPaymentRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("issuerPaymentRefNo");
            entity.Property(e => e.MissingFields)
                .IsUnicode(false)
                .HasColumnName("missingFields");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OrderDateTime)
                .HasColumnType("datetime")
                .HasColumnName("orderDateTime");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrderSl).HasColumnName("OrderSL");
            entity.Property(e => e.PaymentMedia)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaymentRefId)
                .IsUnicode(false)
                .HasColumnName("paymentRefId");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Response).IsUnicode(false);
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serviceType");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("statusCode");
            entity.Property(e => e.StoreNameKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateStoreNameKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("updateStoreNameKey");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<PaymentInfoDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Particular)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Order).WithMany(p => p.PaymentInfoDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PaymentInfoDetails_PaymentInfo");
        });

        modelBuilder.Entity<PaymentInfoIpnLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentInfo_IPN_log", "cw_admin");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Smsresponse).HasColumnName("SMSResponse");
        });

        modelBuilder.Entity<PaymentInfoLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentInfo_log");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ErrorMsg).IsUnicode(false);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Response).IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Smsresponse)
                .IsUnicode(false)
                .HasColumnName("SMSResponse");
        });

        modelBuilder.Entity<PaymentOpenStudentInfo>(entity =>
        {
            entity.ToTable("PaymentOpenStudentInfo");

            entity.Property(e => e.FathersName).HasMaxLength(250);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegNo).HasMaxLength(50);
            entity.Property(e => e.RollNo).HasMaxLength(50);
            entity.Property(e => e.StudentName).HasMaxLength(250);
        });

        modelBuilder.Entity<PaymentStore>(entity =>
        {
            entity.HasKey(e => e.StoreNameKey);

            entity.ToTable("PaymentStores", "cw_admin");

            entity.Property(e => e.StoreNameKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StoreTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PeriodSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PeriodSetting");

            entity.HasIndex(e => e.PeriodName, "PeriodUnique").IsUnique();

            entity.Property(e => e.PeriodId).ValueGeneratedOnAdd();
            entity.Property(e => e.PeriodName).HasMaxLength(50);
        });

        modelBuilder.Entity<PostOffice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Post_Office");

            entity.Property(e => e.PostOfficeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PostOfficeID");
            entity.Property(e => e.PostOfficeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PostOfficeNameBn).HasMaxLength(100);
        });

        modelBuilder.Entity<QuestionPattern>(entity =>
        {
            entity.HasKey(e => e.Qpid);

            entity.ToTable("QuestionPattern");

            entity.Property(e => e.Qpid).HasColumnName("QPId");
            entity.Property(e => e.Qpname)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("QPName");
        });

        modelBuilder.Entity<ReportItem>(entity =>
        {
            entity.HasKey(e => e.Riid).HasName("PK__ReportIt__464E992E2AC5AB2D");

            entity.ToTable("ReportItem");

            entity.Property(e => e.Riid).HasColumnName("RIID");
            entity.Property(e => e.Formula).HasColumnType("image");
            entity.Property(e => e.Notes).HasColumnType("image");
            entity.Property(e => e.Riindex).HasColumnName("RIIndex");
            entity.Property(e => e.Riname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("RIName");
            entity.Property(e => e.UnitName)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResultPublishedLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Result_PublishedLog");

            entity.Property(e => e.ActionTime).HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<SalarySetLog>(entity =>
        {
            entity.HasKey(e => e.SaLid);

            entity.ToTable("SalarySetLog");

            entity.Property(e => e.SaLid).HasColumnName("SaLId");
            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.SaId).HasColumnName("SaID");
            entity.Property(e => e.SaLchangedBy).HasColumnName("SaLChangedBy");
            entity.Property(e => e.SaLdate)
                .HasColumnType("date")
                .HasColumnName("SaLDate");
            entity.Property(e => e.SaLnewSaGovt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SaLNewSaGovt");
            entity.Property(e => e.SaLnewSaSchool)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SaLNewSaSchool");
            entity.Property(e => e.SaLoldSaGovt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SaLOldSaGovt");
            entity.Property(e => e.SaLsaOldSchool)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SaLSaOldSchool");
        });

        modelBuilder.Entity<Salaryset>(entity =>
        {
            entity.HasKey(e => e.SaId).HasName("PK_salaryset");

            entity.ToTable("Salaryset");

            entity.Property(e => e.SaId).HasColumnName("SaID");
            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.SaGovtOrBasic).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaSchool).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaStaus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SaTotal).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EidNavigation).WithMany(p => p.Salarysets)
                .HasForeignKey(d => d.Eid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Salaryset_EmployeeInfo");
        });

        modelBuilder.Entity<SchClass>(entity =>
        {
            entity.HasKey(e => e.SchClassid).HasName("PK__SchClass__FFE76E831B8278B3");

            entity.ToTable("SchClass");

            entity.Property(e => e.SchClassid).HasColumnName("schClassid");
            entity.Property(e => e.AutoBind).HasDefaultValueSql("((1))");
            entity.Property(e => e.CheckIn).HasDefaultValueSql("((1))");
            entity.Property(e => e.CheckInTime1).HasColumnType("datetime");
            entity.Property(e => e.CheckInTime2).HasColumnType("datetime");
            entity.Property(e => e.CheckOut).HasDefaultValueSql("((1))");
            entity.Property(e => e.CheckOutTime1).HasColumnType("datetime");
            entity.Property(e => e.CheckOutTime2).HasColumnType("datetime");
            entity.Property(e => e.Color).HasDefaultValueSql("((16715535))");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.SchName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("schName");
            entity.Property(e => e.SensorId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SensorID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.WorkDay).HasDefaultValueSql("((1))");
            entity.Property(e => e.WorkMins).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<SchoolSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("School_Setup");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("DSId");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogoName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasIndex(e => e.SectionName, "UNQ_Sections").IsUnique();

            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Securitydetail>(entity =>
        {
            entity.HasKey(e => e.Securitydetailid).HasName("NAMEID2");

            entity.ToTable("SECURITYDETAILS");

            entity.Property(e => e.Securitydetailid).HasColumnName("SECURITYDETAILID");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Enrollfingers).HasColumnName("ENROLLFINGERS");
            entity.Property(e => e.Report)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPORT");
            entity.Property(e => e.Reportview).HasColumnName("REPORTVIEW");
            entity.Property(e => e.Schedule).HasColumnName("SCHEDULE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userinfo).HasColumnName("USERINFO");
        });

        modelBuilder.Entity<ServerLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ServerLog");

            entity.Property(e => e.EnrollNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Event)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EVENT");
            entity.Property(e => e.Eventtime)
                .HasColumnType("datetime")
                .HasColumnName("EVENTTIME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.Parameter).HasColumnName("parameter");
            entity.Property(e => e.Sensorid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENSORID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Shiftid).HasName("SHIFTS");

            entity.ToTable("SHIFT");

            entity.Property(e => e.Shiftid).HasColumnName("SHIFTID");
            entity.Property(e => e.Cycle)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CYCLE");
            entity.Property(e => e.Enddate)
                .HasDefaultValueSql("('1900-12-31')")
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Runnum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RUNNUM");
            entity.Property(e => e.Sch1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH1");
            entity.Property(e => e.Sch10)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH10");
            entity.Property(e => e.Sch11)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH11");
            entity.Property(e => e.Sch12)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH12");
            entity.Property(e => e.Sch2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH2");
            entity.Property(e => e.Sch3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH3");
            entity.Property(e => e.Sch4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH4");
            entity.Property(e => e.Sch5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH5");
            entity.Property(e => e.Sch6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH6");
            entity.Property(e => e.Sch7)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH7");
            entity.Property(e => e.Sch8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH8");
            entity.Property(e => e.Sch9)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCH9");
            entity.Property(e => e.Startdate)
                .HasDefaultValueSql("('1900-1-1')")
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Units)
                .HasDefaultValueSql("((0))")
                .HasColumnName("UNITS");
            entity.Property(e => e.Ushiftid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("USHIFTID");
        });

        modelBuilder.Entity<ShiftConfiguration>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("ShiftConfiguration");

            entity.HasIndex(e => e.ShiftName, "IX_ShiftConfiguration").IsUnique();

            entity.Property(e => e.AbsentTime)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CloseTime)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.LateTime)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentAbsentDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AbsenId).ValueGeneratedOnAdd();
            entity.Property(e => e.AbsentDate).HasColumnType("date");
            entity.Property(e => e.PayDate).HasColumnType("date");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentAbsentDetails_StudentProfile");
        });

        modelBuilder.Entity<StudentActivationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentActivation_Log");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Note)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<StudentAdmissionFormInfo>(entity =>
        {
            entity.HasKey(e => e.AdmissionFormNo);

            entity.ToTable("Student_AdmissionFormInfo");

            entity.Property(e => e.AdmissionFormNo).ValueGeneratedNever();
            entity.Property(e => e.AdmissionDate).HasColumnType("date");
            entity.Property(e => e.AppovedTime).HasColumnType("datetime");
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FathersMobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FathersName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FathersNameBn).HasMaxLength(100);
            entity.Property(e => e.FathersProfession)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FathersProfessionBn).HasMaxLength(100);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullNameBn).HasMaxLength(100);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GuardianMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.GuardianName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GuardianRelation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ManSubId).HasMaxLength(50);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MoneyReceiptNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MothersMobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MothersName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MothersNameBn).HasMaxLength(100);
            entity.Property(e => e.MothersProfession)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MothersProfessionBn).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.NuadmissionRoll)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUAdmissionRoll");
            entity.Property(e => e.OpSubId).HasMaxLength(50);
            entity.Property(e => e.ParentsAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParentsAddressBn).HasMaxLength(100);
            entity.Property(e => e.PermanentAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddressBn).HasMaxLength(100);
            entity.Property(e => e.PreScboard)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PreSCBoard");
            entity.Property(e => e.PreScboardHonours)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PreSCBoardHonours");
            entity.Property(e => e.PreScboardHsc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PreSCBoardHSC");
            entity.Property(e => e.PreScgpa).HasColumnName("PreSCGPA");
            entity.Property(e => e.PreScgpahonours).HasColumnName("PreSCGPAHonours");
            entity.Property(e => e.PreScgpahsc).HasColumnName("PreSCGPAHSC");
            entity.Property(e => e.PreSchoolName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PreSchoolNameHonours)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PreSchoolNameHsc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PreSchoolNameHSC");
            entity.Property(e => e.PreScpassingYear).HasColumnName("PreSCPassingYear");
            entity.Property(e => e.PreScpassingYearHonours).HasColumnName("PreSCPassingYearHonours");
            entity.Property(e => e.PreScpassingYearHsc).HasColumnName("PreSCPassingYearHSC");
            entity.Property(e => e.PreScregistration)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PreSCRegistration");
            entity.Property(e => e.PreScregistrationHonours)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PreSCRegistrationHonours");
            entity.Property(e => e.PreScregistrationHsc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PreSCRegistrationHSC");
            entity.Property(e => e.PreScrollNo).HasColumnName("PreSCRollNo");
            entity.Property(e => e.PreScrollNoHonours).HasColumnName("PreSCRollNoHonours");
            entity.Property(e => e.PreScrollNoHsc).HasColumnName("PreSCRollNoHSC");
            entity.Property(e => e.PresentAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddressBn).HasMaxLength(100);
            entity.Property(e => e.Religion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Session)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Tccollege)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TCCollege");
            entity.Property(e => e.Tcdate)
                .HasColumnType("date")
                .HasColumnName("TCDate");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<StudentAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentAttendance");

            entity.Property(e => e.AttenDate).HasColumnType("date");
            entity.Property(e => e.AttenId).ValueGeneratedOnAdd();
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentAttendance_StudentProfile");
        });

        modelBuilder.Entity<StudentFailList>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_ExamFailList");

            entity.ToTable("StudentFailList");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GetMarks).HasColumnName("getMarks");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentFailLists)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentFailList_CurrentStudentInfo");
        });

        modelBuilder.Entity<StudentFine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentFine");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.FineId).ValueGeneratedOnAdd();
            entity.Property(e => e.FinePurpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PayDate).HasColumnType("date");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentFine_CurrentStudentInfo");
        });

        modelBuilder.Entity<StudentFineSetting>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FinePurpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sfsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SFSId");
        });

        modelBuilder.Entity<StudentGroupSubSetup>(entity =>
        {
            entity.HasKey(e => e.SgsubId);

            entity.ToTable("StudentGroupSubSetup");

            entity.Property(e => e.SgsubId).HasColumnName("SGSubId");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentGroupSubSetups)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentGroupSubSetup_StudentGroupSubSetup");
        });

        modelBuilder.Entity<StudentGroupSubSetupDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Msstatus).HasColumnName("MSStatus");
            entity.Property(e => e.SgsubId).HasColumnName("SGSubId");

            entity.HasOne(d => d.Sgsub).WithMany()
                .HasForeignKey(d => d.SgsubId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentGroupSubSetupDetails_StudentGroupSubSetup");
        });

        modelBuilder.Entity<StudentGroupSubjectDetailsTemp>(entity =>
        {
            entity.ToTable("StudentGroupSubjectDetailsTemp", "cw_admin");

            entity.HasIndex(e => e.SgsId, "IX_StudentGroupSubjectDetailsTemp_SgsId");

            entity.Property(e => e.Msstatus).HasColumnName("MSStatus");

            entity.HasOne(d => d.Sgs).WithMany(p => p.StudentGroupSubjectDetailsTemps).HasForeignKey(d => d.SgsId);
        });

        modelBuilder.Entity<StudentGroupSubjectInfoTemp>(entity =>
        {
            entity.HasKey(e => e.SgsId);

            entity.ToTable("StudentGroupSubjectInfoTemp", "cw_admin");

            entity.HasIndex(e => new { e.StudentId, e.BatchId }, "IX_StudentGroupSubjectInfoTemp_StudentId_BatchID").IsUnique();

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
        });

        modelBuilder.Entity<StudentPassingYearForAdmission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student_PassingYearForAdmission");
        });

        modelBuilder.Entity<StudentPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentPayment");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.DiscountTk).HasColumnName("DiscountTK");
            entity.Property(e => e.OthersParticular).HasMaxLength(100);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.StudentPaymentId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentPayment_StudentProfile");
        });

        modelBuilder.Entity<SubjectQuestionPattern>(entity =>
        {
            entity.HasKey(e => e.SubQpid).HasName("PK_SubjectQuestionPattern_1");

            entity.ToTable("SubjectQuestionPattern");

            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.Qmarks).HasColumnName("QMarks");
            entity.Property(e => e.Qpid).HasColumnName("QPId");
            entity.Property(e => e.SubQpmarks).HasColumnName("SubQPMarks");

            entity.HasOne(d => d.Ex).WithMany(p => p.SubjectQuestionPatterns)
                .HasForeignKey(d => d.ExId)
                .HasConstraintName("FK_SubjectQuestionPattern_ExamType");

            entity.HasOne(d => d.Qp).WithMany(p => p.SubjectQuestionPatterns)
                .HasForeignKey(d => d.Qpid)
                .HasConstraintName("FK_SubjectQuestionPattern_QuestionPattern");
        });

        modelBuilder.Entity<SystemLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SystemLo__3214EC27610E6C3C");

            entity.ToTable("SystemLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LogDescr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MachineAlias)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tbkey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBKEY");

            entity.Property(e => e.Onekey).HasColumnName("ONEKEY");
            entity.Property(e => e.PreName)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAdmDateOfPayment>(entity =>
        {
            entity.HasKey(e => e.AdmDateOfPaymentId);

            entity.ToTable("Tbl_Adm_DateOfPayment");

            entity.Property(e => e.DateOfEnd).HasColumnType("date");
            entity.Property(e => e.DateOfStart).HasColumnType("date");

            entity.HasOne(d => d.AdmFeeCat).WithMany(p => p.TblAdmDateOfPayments)
                .HasForeignKey(d => d.AdmFeeCatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbl_Adm_DateOfPayment_Tbl_Adm_FeesCategory");
        });

        modelBuilder.Entity<TblAdmFeesCategory>(entity =>
        {
            entity.HasKey(e => e.AdmFeeCatId);

            entity.ToTable("Tbl_Adm_FeesCategory");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DateOfCreation).HasColumnType("date");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAdmParticularsCategory>(entity =>
        {
            entity.HasKey(e => e.AdmCatPid);

            entity.ToTable("Tbl_Adm_ParticularsCategory");

            entity.Property(e => e.AdmCatPid).HasColumnName("AdmCatPId");
            entity.Property(e => e.Pid).HasColumnName("PId");

            entity.HasOne(d => d.AdmFeeCat).WithMany(p => p.TblAdmParticularsCategories)
                .HasForeignKey(d => d.AdmFeeCatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbl_Adm_ParticularsCategory_Tbl_Adm_FeesCategory");

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.TblAdmParticularsCategories)
                .HasForeignKey(d => d.Pid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbl_Adm_ParticularsCategory_ParticularsInfo");
        });

        modelBuilder.Entity<TblBuIldingName>(entity =>
        {
            entity.HasKey(e => e.BuildingId);

            entity.ToTable("Tbl_Bu‎ilding_Name");

            entity.Property(e => e.BuildingCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BuildingName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblBuildingWithRoom>(entity =>
        {
            entity.HasKey(e => e.RoomId);

            entity.ToTable("Tbl_BuildingWith_Room");

            entity.Property(e => e.RoomCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoomName).HasMaxLength(50);

            entity.HasOne(d => d.Building).WithMany(p => p.TblBuildingWithRooms)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_Tbl_BuildingWith_Room_Tbl_Bu‎ilding_Name");
        });

        modelBuilder.Entity<TblBusInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_BusInformation");

            entity.Property(e => e.BusId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BusID");
            entity.Property(e => e.BusName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblClassGroup>(entity =>
        {
            entity.HasKey(e => e.ClsGrpId);

            entity.ToTable("Tbl_Class_Group");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.HasOne(d => d.Class).WithMany(p => p.TblClassGroups)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbl_Class_Group_Classes");

            entity.HasOne(d => d.Group).WithMany(p => p.TblClassGroups)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_Tbl_Class_Group_Tbl_Class_Group");
        });

        modelBuilder.Entity<TblClassRoutine>(entity =>
        {
            entity.HasKey(e => e.ClassRoutineId);

            entity.ToTable("Tbl_Class_Routine");

            entity.Property(e => e.ClassRoutineId).HasColumnName("ClassRoutineID");
            entity.Property(e => e.ClsTimeId).HasColumnName("ClsTimeID");
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
        });

        modelBuilder.Entity<TblClassSection>(entity =>
        {
            entity.HasKey(e => e.ClsSecId);

            entity.ToTable("Tbl_Class_Section");

            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");

            entity.HasOne(d => d.Class).WithMany(p => p.TblClassSections)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbl_Class_Section_Classes");

            entity.HasOne(d => d.Section).WithMany(p => p.TblClassSections)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK_Tbl_Class_Section_Sections");
        });

        modelBuilder.Entity<TblClassTimeSpecification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_ClassTime_Specification");

            entity.Property(e => e.ClsTimeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ClsTimeID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Period)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblExamMonthlyTestDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_Exam_MonthlyTestDetails");

            entity.Property(e => e.MonthlyTestId).HasColumnName("MonthlyTest_Id");

            entity.HasOne(d => d.MonthlyTest).WithMany()
                .HasForeignKey(d => d.MonthlyTestId)
                .HasConstraintName("FK_Tbl_Exam_MonthlyTestDetails_Tbl_Exam_MontlyTest");
        });

        modelBuilder.Entity<TblExamMontlyTest>(entity =>
        {
            entity.HasKey(e => e.MonthlyTestId).HasName("PK_MontlyTest");

            entity.ToTable("Tbl_Exam_MontlyTest");

            entity.Property(e => e.MonthlyTestId).HasColumnName("MonthlyTest_Id");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblExamTimeSetName>(entity =>
        {
            entity.HasKey(e => e.ExamTimeSetNameId);

            entity.ToTable("Tbl_Exam_Time_SetName");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TblExamTimeSettingsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Exam_TimeSettings_Details");

            entity.Property(e => e.Details1).IsUnicode(false);
            entity.Property(e => e.Details2).IsUnicode(false);
            entity.Property(e => e.Details3).IsUnicode(false);
            entity.Property(e => e.Details4).IsUnicode(false);
            entity.Property(e => e.Details5).IsUnicode(false);
            entity.Property(e => e.ExScSl).ValueGeneratedOnAdd();
            entity.Property(e => e.ExamDate).HasColumnType("date");
            entity.Property(e => e.ExamTimeDuration1)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.ExamTimeDuration2)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.ExamTimeDuration3)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.ExamTimeDuration4)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.ExamTimeDuration5)
                .HasMaxLength(18)
                .IsUnicode(false);

            entity.HasOne(d => d.ExSc).WithMany()
                .HasForeignKey(d => d.ExScId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Exam_TimeSettings_Details_tbl_Exam_TimeSettings_Info");
        });

        modelBuilder.Entity<TblExamTimeSettingsInfo>(entity =>
        {
            entity.HasKey(e => e.ExScId).HasName("PK_tbl_Exam_TimeSet_Info");

            entity.ToTable("tbl_Exam_TimeSettings_Info");

            entity.HasIndex(e => e.ExamTimeSetNameId, "Unique_ExamTimeSetNameId").IsUnique();
        });

        modelBuilder.Entity<TblExamTimeSpecification>(entity =>
        {
            entity.HasKey(e => e.ExamTimeId);

            entity.ToTable("Tbl_ExamTime_Specification");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Period)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("Tbl_Group");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblGuideTeacher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Guide_Teacher");

            entity.Property(e => e.Eid).HasColumnName("EID");

            entity.HasOne(d => d.EidNavigation).WithMany()
                .HasForeignKey(d => d.Eid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Guide_Teacher_EmployeeInfo");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Guide_Teacher_CurrentStudentInfo");
        });

        modelBuilder.Entity<TblLocationInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_Location_Information");

            entity.Property(e => e.LocationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblPhoneBook>(entity =>
        {
            entity.HasKey(e => e.NumId);

            entity.ToTable("Tbl_Phone_book");

            entity.Property(e => e.NumId).HasColumnName("NumID");
            entity.Property(e => e.GrpId).HasColumnName("GrpID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Number)
                .HasMaxLength(20)
                .IsFixedLength();

            entity.HasOne(d => d.Grp).WithMany(p => p.TblPhoneBooks)
                .HasForeignKey(d => d.GrpId)
                .HasConstraintName("FK_Tbl_Phone_book_Tbl_Phone_Group");
        });

        modelBuilder.Entity<TblPhoneGroup>(entity =>
        {
            entity.HasKey(e => e.GrpId);

            entity.ToTable("Tbl_Phone_Group");

            entity.Property(e => e.GrpId).HasColumnName("GrpID");
            entity.Property(e => e.GrpName)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblPlaceInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_Place_Information");

            entity.Property(e => e.PlaceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PlaceID");
            entity.Property(e => e.PlaceName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSectionChangeLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_SectionChange_Log");

            entity.Property(e => e.ChangeDate).HasColumnType("date");
            entity.Property(e => e.NewClsSecId).HasColumnName("NewClsSecID");
            entity.Property(e => e.PreClsSecId).HasColumnName("PreClsSecID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<TblSession>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("Tbl_Session");

            entity.Property(e => e.EndMonth).HasColumnType("datetime");
            entity.Property(e => e.SessionName).HasMaxLength(50);
            entity.Property(e => e.StartMonth).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSmsBody>(entity =>
        {
            entity.HasKey(e => e.TitleId).HasName("PK_TBL_SMS_Body");

            entity.ToTable("Tbl_SMS_Body");

            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSmsReport>(entity =>
        {
            entity.HasKey(e => e.SmsreportId);

            entity.ToTable("Tbl_SMS_Report");

            entity.Property(e => e.SmsreportId).HasColumnName("SMSReportID");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.Purpose).HasMaxLength(50);
            entity.Property(e => e.SentTime).HasColumnType("datetime");
            entity.Property(e => e.Smsid)
                .HasColumnType("money")
                .HasColumnName("SMSID");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<TblSmsTransactionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_SMS_TransactionLog");

            entity.Property(e => e.InsertedSmsIds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("insertedSmsIds");
            entity.Property(e => e.SendingTime).HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Smstype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMStype");
        });

        modelBuilder.Entity<TblStdAdmissionInfo>(entity =>
        {
            entity.HasKey(e => e.AdmissionId);

            entity.ToTable("TBL_STD_Admission_INFO");

            entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");
            entity.Property(e => e.AdmissionDate).HasColumnType("date");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.EndBatchId).HasColumnName("EndBatchID");
            entity.Property(e => e.Session)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StartBatchId).HasColumnName("StartBatchID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStdAdmissionInfos)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TBL_STD_Admission_INFO_CurrentStudentInfo");
        });

        modelBuilder.Entity<TblStdType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_StdType");

            entity.Property(e => e.StdTypeId).ValueGeneratedOnAdd();
            entity.Property(e => e.StdTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSubjectTeacher>(entity =>
        {
            entity.HasKey(e => e.SubTecherId);

            entity.ToTable("Tbl_Subject_Teacher");

            entity.Property(e => e.Eid).HasColumnName("EId");

            entity.HasOne(d => d.Class).WithMany(p => p.TblSubjectTeachers)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbl_Subject_Teacher_Classes");

            entity.HasOne(d => d.EidNavigation).WithMany(p => p.TblSubjectTeachers)
                .HasForeignKey(d => d.Eid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbl_Subject_Teacher_EmployeeInfo");

            entity.HasOne(d => d.Sub).WithMany(p => p.TblSubjectTeachers)
                .HasForeignKey(d => d.SubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbl_Subject_Teacher_NewSubject");
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.HasKey(e => e.TrnsId);

            entity.ToTable("Tbl_Transaction");

            entity.Property(e => e.TrnsId).HasColumnName("trnsID");
            entity.Property(e => e.OthersId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OthersID");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblWeeklyDay>(entity =>
        {
            entity.HasKey(e => e.WdayId);

            entity.ToTable("Tbl_Weekly_days");

            entity.Property(e => e.WdayId).HasColumnName("WDayId");
            entity.Property(e => e.DayName).HasMaxLength(50);
            entity.Property(e => e.ShortDayName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tbsmsallot>(entity =>
        {
            entity.HasKey(e => e.Reference).HasName("PK__TBSMSALL__CAA2317DDA5B0842");

            entity.ToTable("TBSMSALLOT");

            entity.Property(e => e.Reference)
                .ValueGeneratedNever()
                .HasColumnName("REFERENCE");
            entity.Property(e => e.Gentm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GENTM");
            entity.Property(e => e.Smsref).HasColumnName("SMSREF");
            entity.Property(e => e.Userref).HasColumnName("USERREF");
        });

        modelBuilder.Entity<Tbsmsinfo>(entity =>
        {
            entity.HasKey(e => e.Reference).HasName("PK__TBSMSINF__CAA2317D3B15C45A");

            entity.ToTable("TBSMSINFO");

            entity.HasIndex(e => e.Smsid, "UK_SMSINFOCode").IsUnique();

            entity.Property(e => e.Reference)
                .ValueGeneratedNever()
                .HasColumnName("REFERENCE");
            entity.Property(e => e.Gentm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GENTM");
            entity.Property(e => e.Smscontent)
                .HasColumnType("text")
                .HasColumnName("SMSCONTENT");
            entity.Property(e => e.Smsid)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SMSID");
            entity.Property(e => e.Smsindex).HasColumnName("SMSINDEX");
            entity.Property(e => e.Smsstarttm)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SMSSTARTTM");
            entity.Property(e => e.Smstmleng).HasColumnName("SMSTMLENG");
            entity.Property(e => e.Smstype).HasColumnName("SMSTYPE");
        });

        modelBuilder.Entity<TeCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("TE_Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Category).HasMaxLength(50);
        });

        modelBuilder.Entity<TeCommittee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TE_Committee");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Session).WithMany()
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TE_Committee_TE_Session");
        });

        modelBuilder.Entity<TeNumberPattern>(entity =>
        {
            entity.HasKey(e => e.NumPatternId).HasName("PK_ET_NumberRange");

            entity.ToTable("TE_NumberPattern");

            entity.Property(e => e.NumPatternId).HasColumnName("NumPatternID");
            entity.Property(e => e.NumPattern).HasMaxLength(50);
        });

        modelBuilder.Entity<TeNumberPatternDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TE_NumberPatternDetails");

            entity.Property(e => e.NumPatternId).HasColumnName("NumPatternID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.NumPattern).WithMany()
                .HasForeignKey(d => d.NumPatternId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TE_NumberPatternDetails_TE_NumberPattern");
        });

        modelBuilder.Entity<TeNumberSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TE_NumberSheet");

            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.Session).WithMany()
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TE_NumberSheet_TE_Session");
        });

        modelBuilder.Entity<TeSession>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("TE_Session");

            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.NumPatternId).HasColumnName("NumPatternID");
            entity.Property(e => e.Session)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.NumPattern).WithMany(p => p.TeSessions)
                .HasForeignKey(d => d.NumPatternId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TE_Session_TE_NumberPattern");
        });

        modelBuilder.Entity<TeSubCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TE_SubCategory");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.SubCategory).HasMaxLength(50);
            entity.Property(e => e.SubCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SubCategoryID");

            entity.HasOne(d => d.Category).WithMany()
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_TE_SubCategory_TE_Category");
        });

        modelBuilder.Entity<TeacherSubjectAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TeacherSubjectAllocation");

            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.Tsaid)
                .ValueGeneratedOnAdd()
                .HasColumnName("TSAId");
        });

        modelBuilder.Entity<TempNewLeaveDateForAlter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_NewLeaveDateForAlter");

            entity.Property(e => e.LeaveDate).HasColumnType("date");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempOldLeaveDateForAlter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_OldLeaveDateForAlter");

            entity.Property(e => e.LeaveDate).HasColumnType("date");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.HasKey(e => e.Templateid).HasName("TEMPLATED");

            entity.ToTable("TEMPLATE");

            entity.HasIndex(e => new { e.Userid, e.Fingerid }, "USERFINGER").IsUnique();

            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Bitmappicture)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE");
            entity.Property(e => e.Bitmappicture2)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE2");
            entity.Property(e => e.Bitmappicture3)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE3");
            entity.Property(e => e.Bitmappicture4)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE4");
            entity.Property(e => e.DivisionFp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DivisionFP");
            entity.Property(e => e.Emachinenum)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EMACHINENUM");
            entity.Property(e => e.Fingerid).HasColumnName("FINGERID");
            entity.Property(e => e.Flag).HasDefaultValueSql("((1))");
            entity.Property(e => e.Template1)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE");
            entity.Property(e => e.Template11)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE1");
            entity.Property(e => e.Template2)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE2");
            entity.Property(e => e.Template3)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE3");
            entity.Property(e => e.Template4)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE4");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Usetype).HasColumnName("USETYPE");
        });

        modelBuilder.Entity<Thana>(entity =>
        {
            entity.Property(e => e.ThanaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThanaNameBn).HasMaxLength(50);

            entity.HasOne(d => d.District).WithMany(p => p.Thanas)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Thanas_Distritcts");
        });

        modelBuilder.Entity<TimingPeriod>(entity =>
        {
            entity.HasKey(e => e.Period);

            entity.ToTable("TimingPeriod");

            entity.Property(e => e.Period)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAccontStudent>(entity =>
        {
            entity.HasKey(e => e.StudentAccId);

            entity.ToTable("UserAccont_Student");

            entity.HasIndex(e => e.UserName, "UserNameUnique").IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserAccount");

            entity.HasIndex(e => e.UserName, "UserNameAsUnique").IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAccountDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UserDid)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserDId");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserAccountDetails_UserAccount");

            entity.HasOne(d => d.UserType).WithMany()
                .HasForeignKey(d => d.UserTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserAccountDetails_UserTypeInfo");
        });

        modelBuilder.Entity<UserAcmachine>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Deviceid }).HasName("UserAC_Machines");

            entity.ToTable("UserACMachines");

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserAcprivilege>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.DeviceId }).HasName("pk_privilege");

            entity.ToTable("UserACPrivilege");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.AcgroupId).HasColumnName("ACGroupID");
            entity.Property(e => e.Verifystyle).HasColumnName("verifystyle");
        });

        modelBuilder.Entity<UserOfRun>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.NumOfRunId, e.Startdate, e.Enddate }).HasName("USER_ST_NUM");

            entity.ToTable("USER_OF_RUN");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.NumOfRunId).HasColumnName("NUM_OF_RUN_ID");
            entity.Property(e => e.Startdate)
                .HasDefaultValueSql("('1900-1-1')")
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Enddate)
                .HasDefaultValueSql("('2099-12-31')")
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.IsnotofRun)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ISNOTOF_RUN");
            entity.Property(e => e.OrderRun).HasColumnName("ORDER_RUN");
        });

        modelBuilder.Entity<UserPrivilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserPrivilege");

            entity.Property(e => e.DeleteAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.SaveAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdateAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.ViewAction).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserPrivilege_UserAccount");
        });

        modelBuilder.Entity<UserSpeday>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Startspecday, e.Dateid }).HasName("USER_SEP");

            entity.ToTable("USER_SPEDAY");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Startspecday)
                .HasDefaultValueSql("('1900-1-1')")
                .HasColumnType("datetime")
                .HasColumnName("STARTSPECDAY");
            entity.Property(e => e.Dateid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("DATEID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.Endspecday)
                .HasDefaultValueSql("('2099-12-31')")
                .HasColumnType("datetime")
                .HasColumnName("ENDSPECDAY");
            entity.Property(e => e.Yuanying)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YUANYING");
        });

        modelBuilder.Entity<UserTempSch>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Cometime, e.Leavetime }).HasName("USER_TEMP");

            entity.ToTable("USER_TEMP_SCH");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Cometime)
                .HasColumnType("datetime")
                .HasColumnName("COMETIME");
            entity.Property(e => e.Leavetime)
                .HasColumnType("datetime")
                .HasColumnName("LEAVETIME");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((1))")
                .HasColumnName("FLAG");
            entity.Property(e => e.Overtime).HasColumnName("OVERTIME");
            entity.Property(e => e.Schclassid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SCHCLASSID");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<UserTypeInfo>(entity =>
        {
            entity.HasKey(e => e.UserTypeId);

            entity.ToTable("UserTypeInfo");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserTypeInfoModulePrivilege>(entity =>
        {
            entity.HasKey(e => e.UserTypeDid).HasName("PK_UserTypeInfoDetails");

            entity.ToTable("UserTypeInfo_ModulePrivilege");

            entity.Property(e => e.UserTypeDid).HasColumnName("UserTypeDId");
            entity.Property(e => e.AcademicModule).HasDefaultValueSql("((1))");
            entity.Property(e => e.AdministrationModule).HasDefaultValueSql("((1))");
            entity.Property(e => e.NotificationModule).HasDefaultValueSql("((1))");
            entity.Property(e => e.ReportsModule).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UserTypePageInfo>(entity =>
        {
            entity.HasKey(e => e.UserTypePageId);

            entity.ToTable("UserTypePageInfo");

            entity.Property(e => e.DeleteAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.GenerateAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.SaveAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdateAction).HasDefaultValueSql("((0))");
            entity.Property(e => e.ViewAction).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.PageName).WithMany(p => p.UserTypePageInfos)
                .HasForeignKey(d => d.PageNameId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserTypePageInfo_PageInfo");

            entity.HasOne(d => d.UserType).WithMany(p => p.UserTypePageInfos)
                .HasForeignKey(d => d.UserTypeId)
                .HasConstraintName("FK_UserTypePageInfo_UserTypeInfo");
        });

        modelBuilder.Entity<UserUpdate>(entity =>
        {
            entity.HasKey(e => e.UpdateId).HasName("PK__UserUpda__7A0CF3C5C3BE129F");

            entity.Property(e => e.BadgeNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserUsedSclass>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.SchId }).HasName("USER_USED_SCL");

            entity.ToTable("UserUsedSClasses");
        });

        modelBuilder.Entity<Userinfo>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("USERIDS");

            entity.ToTable("USERINFO");

            entity.HasIndex(e => e.Badgenumber, "BADGENUMBER").IsUnique();

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.AccGroup).HasDefaultValueSql("((1))");
            entity.Property(e => e.Att)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ATT");
            entity.Property(e => e.AutoSchPlan).HasDefaultValueSql("((1))");
            entity.Property(e => e.Badgenumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("BADGENUMBER");
            entity.Property(e => e.Birthday)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDAY");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Defaultdeptid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DEFAULTDEPTID");
            entity.Property(e => e.Emprivilege)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMPRIVILEGE");
            entity.Property(e => e.Expires).HasDefaultValueSql("((0))");
            entity.Property(e => e.FaceGroup).HasDefaultValueSql("((0))");
            entity.Property(e => e.Fphone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FPHONE");
            entity.Property(e => e.Gender)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GENDER");
            entity.Property(e => e.Hiredday)
                .HasColumnType("datetime")
                .HasColumnName("HIREDDAY");
            entity.Property(e => e.Holiday)
                .HasDefaultValueSql("((1))")
                .HasColumnName("HOLIDAY");
            entity.Property(e => e.InheritDeptRule).HasDefaultValueSql("((1))");
            entity.Property(e => e.InheritDeptSch).HasDefaultValueSql("((1))");
            entity.Property(e => e.InheritDeptSchClass).HasDefaultValueSql("((1))");
            entity.Property(e => e.Inlate)
                .HasDefaultValueSql("((1))")
                .HasColumnName("INLATE");
            entity.Property(e => e.Lunchduration)
                .HasDefaultValueSql("((1))")
                .HasColumnName("LUNCHDURATION");
            entity.Property(e => e.MinAutoSchInterval).HasDefaultValueSql("((24))");
            entity.Property(e => e.Minzu)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("MINZU");
            entity.Property(e => e.MverifyPass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MVerifyPass");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes).HasColumnType("image");
            entity.Property(e => e.Ophone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OPHONE");
            entity.Property(e => e.Outearly)
                .HasDefaultValueSql("((1))")
                .HasColumnName("OUTEARLY");
            entity.Property(e => e.Overtime)
                .HasDefaultValueSql("((1))")
                .HasColumnName("OVERTIME");
            entity.Property(e => e.Pager)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAGER");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("PHOTO");
            entity.Property(e => e.Privilege)
                .HasDefaultValueSql("((0))")
                .HasColumnName("privilege");
            entity.Property(e => e.RegisterOt)
                .HasDefaultValueSql("((1))")
                .HasColumnName("RegisterOT");
            entity.Property(e => e.Securityflags).HasColumnName("SECURITYFLAGS");
            entity.Property(e => e.Sep)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEP");
            entity.Property(e => e.Ssn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.TimeZone1).HasDefaultValueSql("((1))");
            entity.Property(e => e.TimeZone2).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimeZone3).HasDefaultValueSql("((0))");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.UseAccGroupTz)
                .HasDefaultValueSql("((1))")
                .HasColumnName("UseAccGroupTZ");
            entity.Property(e => e.ValidCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.ValidTimeBegin).HasColumnType("datetime");
            entity.Property(e => e.ValidTimeEnd).HasColumnType("datetime");
            entity.Property(e => e.Verificationmethod).HasColumnName("VERIFICATIONMETHOD");
            entity.Property(e => e.VerifyCode).HasDefaultValueSql("((0))");
            entity.Property(e => e.Zip)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<UsersForPortal>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UsersForPortal", "cw_admin");

            entity.HasIndex(e => e.UserName, "IX_UsersForPortal_UserName").IsUnique();
        });

        modelBuilder.Entity<UsersMachine>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Deviceid).HasColumnName("DEVICEID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<VAccountsExpense>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Accounts_Expenses");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ExpensesId).HasColumnName("ExpensesID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
        });

        modelBuilder.Entity<VAccountsIncome>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Accounts_Income");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.IncomeId).HasColumnName("IncomeID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
        });

        modelBuilder.Entity<VAdmFeesCatDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Adm_FeesCatDetails");

            entity.Property(e => e.AdmCatPid).HasColumnName("AdmCatPId");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<VAdmPaymentReprint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Adm_Payment_Reprint");

            entity.Property(e => e.AdmCatPid).HasColumnName("AdmCatPId");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAdmStudentPaymentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Adm_StudentPaymentInfo");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAdmissionStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AdmissionStudent");

            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.DiscountTk).HasColumnName("DiscountTK");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VBatchInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_BatchInfo");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCheckStudentFine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CheckStudentFine");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.DateOfEnd).HasColumnType("date");
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.DateOfStart).HasColumnType("date");
            entity.Property(e => e.DiscountTk).HasColumnName("DiscountTK");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<VCheckinout>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CHECKINOUT");

            entity.Property(e => e.Badgenumber)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.Checktime)
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype)
                .HasMaxLength(1)
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Memoinfo).HasMaxLength(30);
            entity.Property(e => e.Sensorid)
                .HasMaxLength(5)
                .HasColumnName("SENSORID");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .HasColumnName("sn");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Verifycode).HasColumnName("VERIFYCODE");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(24)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VClassGroupSection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Class_Group_Section");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VClassSubjectCourseList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Class_Subject_Course_List");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Csid).HasColumnName("CSId");
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubjectName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VClassSubjectList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ClassSubjectList");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Csid).HasColumnName("CSId");
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VClassSujectListForResultProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ClassSujectListForResultProcess");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.Csid).HasColumnName("CSId");
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VClasswiseSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ClasswiseSubject");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCurrentStudentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CurrentStudentInfo");

            entity.Property(e => e.AdmissionDate).HasColumnType("date");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BusId).HasColumnName("BusID");
            entity.Property(e => e.BusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CertifiedDate).HasColumnType("date");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.Comments)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.ExamDate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ExamDay)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ExamEndTime)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ExamName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ExamStartTime)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FatherDesg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameBn).HasMaxLength(50);
            entity.Property(e => e.FatherOrg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FathersMobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FathersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FathersProfession)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullNameBn).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.GuardianMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.GuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianRelation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HomePhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.IdCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherDesg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotherNameBn).HasMaxLength(50);
            entity.Property(e => e.MotherOrg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotherPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherTongue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MothersMoible)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MothersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MothersProfession)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Padistrict)
                .HasColumnType("text")
                .HasColumnName("PADistrict");
            entity.Property(e => e.PapostOffice)
                .HasColumnType("text")
                .HasColumnName("PAPostOffice");
            entity.Property(e => e.PapostOfficeId).HasColumnName("PAPostOfficeID");
            entity.Property(e => e.PapostOfficeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAPostOfficeName");
            entity.Property(e => e.Pathana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAThana");
            entity.Property(e => e.Pavillage)
                .HasColumnType("text")
                .HasColumnName("PAVillage");
            entity.Property(e => e.PlaceId).HasColumnName("PlaceID");
            entity.Property(e => e.PlaceName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreferredClass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PreviousExamType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreviousSchoolName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pscboard)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PSCBoard");
            entity.Property(e => e.Pscgpa).HasColumnName("PSCGPA");
            entity.Property(e => e.Pscjscregistration)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PSCJSCRegistration");
            entity.Property(e => e.PscpassingYear).HasColumnName("PSCPassingYear");
            entity.Property(e => e.PscrollNo).HasColumnName("PSCRollNo");
            entity.Property(e => e.PthanaId).HasColumnName("PThanaId");
            entity.Property(e => e.Religion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Session)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sscroll).HasColumnName("SSCRoll");
            entity.Property(e => e.StdTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SubCourseId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SubCourseID");
            entity.Property(e => e.SubId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SubID");
            entity.Property(e => e.Subject)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tadistrict)
                .HasColumnType("text")
                .HasColumnName("TADistrict");
            entity.Property(e => e.TapostOffice)
                .HasColumnType("text")
                .HasColumnName("TAPostOffice");
            entity.Property(e => e.TapostOfficeId).HasColumnName("TAPostOfficeID");
            entity.Property(e => e.TapostOfficeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAPostOfficeName");
            entity.Property(e => e.Tathana)
                .HasColumnType("text")
                .HasColumnName("TAThana");
            entity.Property(e => e.TaviIlage)
                .HasColumnType("text")
                .HasColumnName("TAViIlage");
            entity.Property(e => e.Tcclass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TCClass");
            entity.Property(e => e.TccollegeName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TCCollegeName");
            entity.Property(e => e.Tcdate)
                .HasColumnType("date")
                .HasColumnName("TCDate");
            entity.Property(e => e.Tcsemister)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TCSemister");
        });

        modelBuilder.Entity<VCurrentStudentInfoForAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CurrentStudentInfo_ForAttendance");

            entity.Property(e => e.AdmissionDate).HasColumnType("date");
            entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDailyAbsentRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DailyAbsentRecord");

            entity.Property(e => e.AttDate).HasColumnType("date");
            entity.Property(e => e.AttStatus)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDailyAttendanceRecordForReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DailyAttendanceRecordForReport");

            entity.Property(e => e.AdmissionDate).HasColumnType("date");
            entity.Property(e => e.AttDate).HasColumnType("date");
            entity.Property(e => e.AttManual)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.AttStatus)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DailyStartTimeAltCloseTime)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DailyStartTimeALT_CloseTime");
            entity.Property(e => e.FathersMobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MothersMoible)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.OutHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDailyEmployeeAttendanceRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DailyEmployeeAttendanceRecord");

            entity.Property(e => e.AttDate).HasColumnType("date");
            entity.Property(e => e.AttDates).HasColumnType("date");
            entity.Property(e => e.AttManual)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.AttMonth).HasMaxLength(4000);
            entity.Property(e => e.AttStatus)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Egender)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("EGender");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.EjoiningDate)
                .HasColumnType("date")
                .HasColumnName("EJoiningDate");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.InHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LoginTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LogoutTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.OutHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDailyStudentAttendanceRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DailyStudentAttendanceRecord");

            entity.Property(e => e.Ab).HasColumnName("AB");
            entity.Property(e => e.AttDate).HasMaxLength(4000);
            entity.Property(e => e.AttManual)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.AttMonth).HasMaxLength(4000);
            entity.Property(e => e.AttStatus)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LoginTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LogoutTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Lt).HasColumnName("LT");
            entity.Property(e => e.Lv).HasColumnName("LV");
            entity.Property(e => e.OutHur)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Pr).HasColumnName("PR");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ttl).HasColumnName("TTL");
        });

        modelBuilder.Entity<VDateOfPaymentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DateOfPaymentDetails");

            entity.Property(e => e.DateOfEnd).HasColumnType("date");
            entity.Property(e => e.DateOfStart).HasColumnType("date");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Discount");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDiscountParticularDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DiscountParticularDetails");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<VEmpDailyAbsentRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmpDailyAbsentRecord");

            entity.Property(e => e.AttDate).HasColumnType("date");
            entity.Property(e => e.AttStatus)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEmployeeInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmployeeInfo");

            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
            entity.Property(e => e.Ebirthday)
                .HasColumnType("date")
                .HasColumnName("EBirthday");
            entity.Property(e => e.EbloodGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EBloodGroup");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Ecmobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ECMobile");
            entity.Property(e => e.Ecname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ECName");
            entity.Property(e => e.Ecrelation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ECRelation");
            entity.Property(e => e.Eemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EEmail");
            entity.Property(e => e.Eexaminer).HasColumnName("EExaminer");
            entity.Property(e => e.EfathersName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFathersName");
            entity.Property(e => e.Egender)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("EGender");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.EiiclassTeacher).HasColumnName("EIIClassTeacher");
            entity.Property(e => e.EjoiningDate)
                .HasColumnType("date")
                .HasColumnName("EJoiningDate");
            entity.Property(e => e.EjoiningDate1)
                .HasColumnType("date")
                .HasColumnName("EJoiningDate1");
            entity.Property(e => e.ElastDegree)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ELastDegree");
            entity.Property(e => e.EmaritalStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMaritalStatus");
            entity.Property(e => e.Emobile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EMobile");
            entity.Property(e => e.EmothersName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMothersName");
            entity.Property(e => e.EmployeeType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.Enationality)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENationality");
            entity.Property(e => e.EparmanentAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EParmanentAddress");
            entity.Property(e => e.Ephone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EPhone");
            entity.Property(e => e.EpictureName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("EPictureName");
            entity.Property(e => e.EpresentAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EPresentAddress");
            entity.Property(e => e.Ereligion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EReligion");
            entity.Property(e => e.EsignName)
                .HasMaxLength(1000)
                .HasColumnName("ESignName");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EStatus");
            entity.Property(e => e.PerDistrictName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PerPostOfficeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerThanaName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrDistrictName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrPostOfficeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrThanaName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TcodeNo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TCodeNo");
        });

        modelBuilder.Entity<VExamDependencyInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ExamDependencyInfo");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DependencyIexamId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DependencyIExamId");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParentExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VExamExaminee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ExamExaminee");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.ExamineeId).HasColumnName("ExamineeID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<VExamFailedAccordingToNumberOfSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Exam_FailedAccordingToNumberOfSubjects");

            entity.Property(e => e.NumberOfFailSubjectTotalText)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.RollNo).HasMaxLength(4000);
        });

        modelBuilder.Entity<VExamFailedStudentReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Exam_FailedStudentReport");

            entity.Property(e => e.ClassName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.ExamName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.SubName)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VExamInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ExamInfo");

            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExEndDate).HasColumnType("date");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExStartDate).HasColumnType("date");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VExamResutlSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Exam_ResutlSummary");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.ExamName)
                .HasMaxLength(107)
                .IsUnicode(false);
            entity.Property(e => e.Fsub1).HasColumnName("FSub1");
            entity.Property(e => e.Fsub2).HasColumnName("FSub2");
            entity.Property(e => e.Fsub3).HasColumnName("FSub3");
            entity.Property(e => e.Fsub31).HasColumnName("FSub3+");
            entity.Property(e => e.Gpa1).HasColumnName("GPA1");
            entity.Property(e => e.Gpa2).HasColumnName("GPA2");
            entity.Property(e => e.Gpa3).HasColumnName("GPA3");
            entity.Property(e => e.Gpa35).HasColumnName("GPA3.5");
            entity.Property(e => e.Gpa4).HasColumnName("GPA4");
            entity.Property(e => e.Gpa5).HasColumnName("GPA5");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VExamSubjectWiseResultAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Exam_SubjectWiseResultAnalysis:");

            entity.Property(e => e.A).HasColumnName("A-");
            entity.Property(e => e.A1).HasColumnName("A");
            entity.Property(e => e.A2).HasColumnName("A+");
            entity.Property(e => e.Aa).HasColumnName("AA");
            entity.Property(e => e.SubName)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VFeesCatDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FeesCatDetails");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CatPid).HasColumnName("CatPId");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.StdTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StoreNameKey)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VFinlaResultLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FinlaResultLog");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gpa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GPA");
            entity.Property(e => e.Grade)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Sgrade)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SGrade");
            entity.Property(e => e.Shift)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Spoint).HasColumnName("SPoint");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalMarks)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VGetFineStudentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getFineStudentInfo");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.FinePurpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayDate).HasColumnType("date");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VGuideTeacher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Guide_Teacher");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
            entity.Property(e => e.Egender)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("EGender");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TcodeNo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TCodeNo");
        });

        modelBuilder.Entity<VLeaveApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_Application");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("date");
        });

        modelBuilder.Entity<VLeaveApplicationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_Application_Log");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedRejected)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.PrasaberaDate).HasColumnType("date");
            entity.Property(e => e.PregnantDate).HasColumnType("date");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("date");
        });

        modelBuilder.Entity<VLeaveLeaveApplicationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_LeaveApplicationDetails");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Dstatus).HasColumnName("DStatus");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.FromYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveDate).HasColumnType("date");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrasaberaDate).HasColumnType("date");
            entity.Property(e => e.PregnantDate).HasColumnType("date");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ToDate).HasColumnType("date");
            entity.Property(e => e.ToYear)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMoanthlyAttendanceSheetReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Moanthly_Attendance_Sheet_Report");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lv).HasColumnName("LV");
            entity.Property(e => e.MonthId).HasMaxLength(4000);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e._1).HasColumnName("1");
            entity.Property(e => e._10).HasColumnName("10");
            entity.Property(e => e._11).HasColumnName("11");
            entity.Property(e => e._12).HasColumnName("12");
            entity.Property(e => e._13).HasColumnName("13");
            entity.Property(e => e._14).HasColumnName("14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._2).HasColumnName("2");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._25).HasColumnName("25");
            entity.Property(e => e._26).HasColumnName("26");
            entity.Property(e => e._27).HasColumnName("27");
            entity.Property(e => e._28).HasColumnName("28");
            entity.Property(e => e._29).HasColumnName("29");
            entity.Property(e => e._3).HasColumnName("3");
            entity.Property(e => e._30).HasColumnName("30");
            entity.Property(e => e._31).HasColumnName("31");
            entity.Property(e => e._4).HasColumnName("4");
            entity.Property(e => e._5).HasColumnName("5");
            entity.Property(e => e._6).HasColumnName("6");
            entity.Property(e => e._7).HasColumnName("7");
            entity.Property(e => e._8).HasColumnName("8");
            entity.Property(e => e._9).HasColumnName("9");
        });

        modelBuilder.Entity<VPhotoAlbum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_photoAlbum");

            entity.Property(e => e.AlbumName).HasMaxLength(50);
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Pasl).HasColumnName("PASL");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VSalarySetDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SalarySetDetails");

            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.SaGovtOrBasic).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaSchool).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaStaus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SaTotal).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VStudentAbsentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentAbsentDetails");

            entity.Property(e => e.AbsentDate).HasColumnType("date");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.FinePurpose)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayDate).HasColumnType("date");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStudentGroupSubSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentGroupSubSetup");

            entity.Property(e => e.Msstatus).HasColumnName("MSStatus");
            entity.Property(e => e.SgsubId).HasColumnName("SGSubId");
        });

        modelBuilder.Entity<VStudentGroupSubSetupDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentGroupSubSetupDetails");

            entity.Property(e => e.BatchName)
                .HasMaxLength(220)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Msstatus).HasColumnName("MSStatus");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SgsubId).HasColumnName("SGSubId");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStudentMoneyReceipt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentMoneyReceipt");

            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.DiscountTk).HasColumnName("DiscountTK");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStudentPaymentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentPaymentDetails");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.DiscountTk).HasColumnName("DiscountTK");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStudentPaymentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentPaymentInfo");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.DateOfPayment).HasColumnType("date");
            entity.Property(e => e.DiscountTk).HasColumnName("DiscountTK");
            entity.Property(e => e.FeeCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StdTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStudentWiseSubjectList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StudentWiseSubjectList");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSubjectQuestionPattern>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SubjectQuestionPattern");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Qmarks).HasColumnName("QMarks");
            entity.Property(e => e.Qpid).HasColumnName("QPId");
            entity.Property(e => e.Qpname)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("QPName");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubQpid).HasColumnName("SubQPId");
            entity.Property(e => e.SubQpmarks).HasColumnName("SubQPMarks");
        });

        modelBuilder.Entity<VTblClassGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tbl_Class_Group");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblClassRoutine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tbl_Class_Routine");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BuildingName).HasMaxLength(50);
            entity.Property(e => e.ClassRoutineId).HasColumnName("ClassRoutineID");
            entity.Property(e => e.ClsTimeId).HasColumnName("ClsTimeID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.DayName).HasMaxLength(50);
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomName).HasMaxLength(50);
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortDayName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TcodeNo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TCodeNo");
        });

        modelBuilder.Entity<VTblClassSection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tbl_Class_Section");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ClsSecId).HasColumnName("ClsSecID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblExamMonthlyTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tbl_Exam_MonthlyTest");

            entity.Property(e => e.BatchName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClsGrpId).HasColumnName("ClsGrpID");
            entity.Property(e => e.ExEndDate).HasColumnType("date");
            entity.Property(e => e.ExInId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExStartDate).HasColumnType("date");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthlyTestId).HasColumnName("MonthlyTest_Id");
            entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTeacherSubjectAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TeacherSubjectAllocation");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TcodeNo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TCodeNo");
            entity.Property(e => e.Tsaid).HasColumnName("TSAId");
        });

        modelBuilder.Entity<VThanaDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ThanaDetails");

            entity.Property(e => e.DistrictName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistrictNameBn).HasMaxLength(50);
            entity.Property(e => e.ThanaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThanaNameBn).HasMaxLength(50);
        });

        modelBuilder.Entity<VUserAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserAccount");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserAccountDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserAccountDetails");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserAccountStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserAccount_Student");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserPrivilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserPrivilege");

            entity.Property(e => e.ModuleType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserTypeInfoModulePrivilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserTypeInfo_ModulePrivilege");

            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserTypeDid).HasColumnName("UserTypeDId");
        });

        modelBuilder.Entity<VUserTypePageInfoAccurateDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserTypePageInfo_AccurateData");

            entity.Property(e => e.ModuleType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserTypePageInfoAllDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserTypePageInfo_AllData");

            entity.Property(e => e.ModuleType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVDailyAttendanceRecordForReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_DailyAttendanceRecordForReport");

            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e._10InH).HasColumnName("10_InH");
            entity.Property(e => e._10InM).HasColumnName("10_InM");
            entity.Property(e => e._10OutH).HasColumnName("10_OutH");
            entity.Property(e => e._10OutM).HasColumnName("10_OutM");
            entity.Property(e => e._11InH).HasColumnName("11_InH");
            entity.Property(e => e._11InM).HasColumnName("11_InM");
            entity.Property(e => e._11OutH).HasColumnName("11_OutH");
            entity.Property(e => e._11OutM).HasColumnName("11_OutM");
            entity.Property(e => e._12InH).HasColumnName("12_InH");
            entity.Property(e => e._12InM).HasColumnName("12_InM");
            entity.Property(e => e._12OutH).HasColumnName("12_OutH");
            entity.Property(e => e._12OutM).HasColumnName("12_OutM");
            entity.Property(e => e._13InH).HasColumnName("13_InH");
            entity.Property(e => e._13InM).HasColumnName("13_InM");
            entity.Property(e => e._13OutH).HasColumnName("13_OutH");
            entity.Property(e => e._13OutM).HasColumnName("13_OutM");
            entity.Property(e => e._14InH).HasColumnName("14_InH");
            entity.Property(e => e._14InM).HasColumnName("14_InM");
            entity.Property(e => e._14OutH).HasColumnName("14_OutH");
            entity.Property(e => e._14OutM).HasColumnName("14_OutM");
            entity.Property(e => e._15InH).HasColumnName("15_InH");
            entity.Property(e => e._15InM).HasColumnName("15_InM");
            entity.Property(e => e._15OutH).HasColumnName("15_OutH");
            entity.Property(e => e._15OutM).HasColumnName("15_OutM");
            entity.Property(e => e._16InH).HasColumnName("16_InH");
            entity.Property(e => e._16InM).HasColumnName("16_InM");
            entity.Property(e => e._16OutH).HasColumnName("16_OutH");
            entity.Property(e => e._16OutM).HasColumnName("16_OutM");
            entity.Property(e => e._17InH).HasColumnName("17_InH");
            entity.Property(e => e._17InM).HasColumnName("17_InM");
            entity.Property(e => e._17OutH).HasColumnName("17_OutH");
            entity.Property(e => e._17OutM).HasColumnName("17_OutM");
            entity.Property(e => e._18InH).HasColumnName("18_InH");
            entity.Property(e => e._18InM).HasColumnName("18_InM");
            entity.Property(e => e._18OutH).HasColumnName("18_OutH");
            entity.Property(e => e._18OutM).HasColumnName("18_OutM");
            entity.Property(e => e._19InH).HasColumnName("19_InH");
            entity.Property(e => e._19InM).HasColumnName("19_InM");
            entity.Property(e => e._19OutH).HasColumnName("19_OutH");
            entity.Property(e => e._19OutM).HasColumnName("19_OutM");
            entity.Property(e => e._1InH).HasColumnName("1_InH");
            entity.Property(e => e._1InM).HasColumnName("1_InM");
            entity.Property(e => e._1OutH).HasColumnName("1_OutH");
            entity.Property(e => e._1OutM).HasColumnName("1_OutM");
            entity.Property(e => e._20InH).HasColumnName("20_InH");
            entity.Property(e => e._20InM).HasColumnName("20_InM");
            entity.Property(e => e._20OutH).HasColumnName("20_OutH");
            entity.Property(e => e._20OutM).HasColumnName("20_OutM");
            entity.Property(e => e._21InH).HasColumnName("21_InH");
            entity.Property(e => e._21InM).HasColumnName("21_InM");
            entity.Property(e => e._21OutH).HasColumnName("21_OutH");
            entity.Property(e => e._21OutM).HasColumnName("21_OutM");
            entity.Property(e => e._22InH).HasColumnName("22_InH");
            entity.Property(e => e._22InM).HasColumnName("22_InM");
            entity.Property(e => e._22OutH).HasColumnName("22_OutH");
            entity.Property(e => e._22OutM).HasColumnName("22_OutM");
            entity.Property(e => e._23InH).HasColumnName("23_InH");
            entity.Property(e => e._23InM).HasColumnName("23_InM");
            entity.Property(e => e._23OutH).HasColumnName("23_OutH");
            entity.Property(e => e._23OutM).HasColumnName("23_OutM");
            entity.Property(e => e._24InH).HasColumnName("24_InH");
            entity.Property(e => e._24InM).HasColumnName("24_InM");
            entity.Property(e => e._24OutH).HasColumnName("24_OutH");
            entity.Property(e => e._24OutM).HasColumnName("24_OutM");
            entity.Property(e => e._25InH).HasColumnName("25_InH");
            entity.Property(e => e._25InM).HasColumnName("25_InM");
            entity.Property(e => e._25OutH).HasColumnName("25_OutH");
            entity.Property(e => e._25OutM).HasColumnName("25_OutM");
            entity.Property(e => e._26InH).HasColumnName("26_InH");
            entity.Property(e => e._26InM).HasColumnName("26_InM");
            entity.Property(e => e._26OutH).HasColumnName("26_OutH");
            entity.Property(e => e._26OutM).HasColumnName("26_OutM");
            entity.Property(e => e._27InH).HasColumnName("27_InH");
            entity.Property(e => e._27InM).HasColumnName("27_InM");
            entity.Property(e => e._27OutH).HasColumnName("27_OutH");
            entity.Property(e => e._27OutM).HasColumnName("27_OutM");
            entity.Property(e => e._28InH).HasColumnName("28_InH");
            entity.Property(e => e._28InM).HasColumnName("28_InM");
            entity.Property(e => e._28OutH).HasColumnName("28_OutH");
            entity.Property(e => e._28OutM).HasColumnName("28_OutM");
            entity.Property(e => e._29InH).HasColumnName("29_InH");
            entity.Property(e => e._29InM).HasColumnName("29_InM");
            entity.Property(e => e._29OutH).HasColumnName("29_OutH");
            entity.Property(e => e._29OutM).HasColumnName("29_OutM");
            entity.Property(e => e._2InH).HasColumnName("2_InH");
            entity.Property(e => e._2InM).HasColumnName("2_InM");
            entity.Property(e => e._2OutH).HasColumnName("2_OutH");
            entity.Property(e => e._2OutM).HasColumnName("2_OutM");
            entity.Property(e => e._30InH).HasColumnName("30_InH");
            entity.Property(e => e._30InM).HasColumnName("30_InM");
            entity.Property(e => e._30OutH).HasColumnName("30_OutH");
            entity.Property(e => e._30OutM).HasColumnName("30_OutM");
            entity.Property(e => e._31InH).HasColumnName("31_InH");
            entity.Property(e => e._31InM).HasColumnName("31_InM");
            entity.Property(e => e._31OutH).HasColumnName("31_OutH");
            entity.Property(e => e._31OutM).HasColumnName("31_OutM");
            entity.Property(e => e._3InH).HasColumnName("3_InH");
            entity.Property(e => e._3InM).HasColumnName("3_InM");
            entity.Property(e => e._3OutH).HasColumnName("3_OutH");
            entity.Property(e => e._3OutM).HasColumnName("3_OutM");
            entity.Property(e => e._4InH).HasColumnName("4_InH");
            entity.Property(e => e._4InM).HasColumnName("4_InM");
            entity.Property(e => e._4OutH).HasColumnName("4_OutH");
            entity.Property(e => e._4OutM).HasColumnName("4_OutM");
            entity.Property(e => e._5InH).HasColumnName("5_InH");
            entity.Property(e => e._5InM).HasColumnName("5_InM");
            entity.Property(e => e._5OutH).HasColumnName("5_OutH");
            entity.Property(e => e._5OutM).HasColumnName("5_OutM");
            entity.Property(e => e._6InH).HasColumnName("6_InH");
            entity.Property(e => e._6InM).HasColumnName("6_InM");
            entity.Property(e => e._6OutH).HasColumnName("6_OutH");
            entity.Property(e => e._6OutM).HasColumnName("6_OutM");
            entity.Property(e => e._7InH).HasColumnName("7_InH");
            entity.Property(e => e._7InM).HasColumnName("7_InM");
            entity.Property(e => e._7OutH).HasColumnName("7_OutH");
            entity.Property(e => e._7OutM).HasColumnName("7_OutM");
            entity.Property(e => e._8InH).HasColumnName("8_InH");
            entity.Property(e => e._8InM).HasColumnName("8_InM");
            entity.Property(e => e._8OutH).HasColumnName("8_OutH");
            entity.Property(e => e._8OutM).HasColumnName("8_OutM");
            entity.Property(e => e._9InH).HasColumnName("9_InH");
            entity.Property(e => e._9InM).HasColumnName("9_InM");
            entity.Property(e => e._9OutH).HasColumnName("9_OutH");
            entity.Property(e => e._9OutM).HasColumnName("9_OutM");
        });

        modelBuilder.Entity<VVLeaveLeaveApplicationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_Leave_LeaveApplicationDetails");

            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.LeaveDate).HasColumnType("date");
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MonthYear)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Ol).HasColumnName("OL");
            entity.Property(e => e.Opl).HasColumnName("OPL");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Year)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVVLeaveLeaveApplicationDetailsForLeaveBalanceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_v_Leave_LeaveApplicationDetails_ForLeaveBalanceReport");

            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.LeaveDate).HasColumnType("date");
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.Ol).HasColumnName("OL");
            entity.Property(e => e.Opl).HasColumnName("OPL");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VVVLeaveYearlyStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_v_Leave_Yearly_Status");

            entity.Property(e => e.AlRemaining).HasColumnName("AL_Remaining");
            entity.Property(e => e.AlSpend).HasColumnName("AL_Spend");
            entity.Property(e => e.AlTotal).HasColumnName("AL_Total");
            entity.Property(e => e.ClRemaining).HasColumnName("CL_Remaining");
            entity.Property(e => e.ClSpend).HasColumnName("CL_Spend");
            entity.Property(e => e.ClTotal).HasColumnName("CL_Total");
            entity.Property(e => e.DesName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.EcardNo).HasColumnName("ECardNo");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
            entity.Property(e => e.MlRemaining).HasColumnName("ML_Remaining");
            entity.Property(e => e.MlSpend).HasColumnName("ML_Spend");
            entity.Property(e => e.MlTotal).HasColumnName("ML_Total");
            entity.Property(e => e.OlRemaining).HasColumnName("OL_Remaining");
            entity.Property(e => e.OlSpend).HasColumnName("OL_Spend");
            entity.Property(e => e.OlTotal).HasColumnName("OL_Total");
            entity.Property(e => e.OplRemaining).HasColumnName("OPL_Remaining");
            entity.Property(e => e.OplSpend).HasColumnName("OPL_Spend");
            entity.Property(e => e.OplTotal).HasColumnName("OPL_Total");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SlRemaining).HasColumnName("SL_Remaining");
            entity.Property(e => e.SlSpend).HasColumnName("SL_Spend");
            entity.Property(e => e.SlTotal).HasColumnName("SL_Total");
            entity.Property(e => e.Year)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VisitorCounter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VisitorCounter");

            entity.Property(e => e.HitNumber).HasColumnName("hitNumber");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("date")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<Workstation>(entity =>
        {
            entity.ToTable("Workstation");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.WorkstationName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WscommonSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSCommonSettings");

            entity.Property(e => e.AdmissionMsg).HasMaxLength(100);
        });

        modelBuilder.Entity<Wsebook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSEBooks");

            entity.Property(e => e.BookDownUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BookImage)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BookReadUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BookTiltle).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WseventInfo>(entity =>
        {
            entity.HasKey(e => e.Esl);

            entity.ToTable("WSEventInfo");

            entity.Property(e => e.Esl).HasColumnName("ESL");
            entity.Property(e => e.EventName).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(200);
        });

        modelBuilder.Entity<WseventInfoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSEventInfoDetails");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Esl).HasColumnName("ESL");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.EslNavigation).WithMany()
                .HasForeignKey(d => d.Esl)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WSEventInfoDetails_WSEventInfo");
        });

        modelBuilder.Entity<WsgalleryInfo>(entity =>
        {
            entity.HasKey(e => e.Pasl);

            entity.ToTable("WSGalleryInfo");

            entity.Property(e => e.Pasl).HasColumnName("PASL");
            entity.Property(e => e.AlbumName).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(200);
        });

        modelBuilder.Entity<WsgalleryInfoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSGalleryInfoDetails");

            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Pasl).HasColumnName("PASL");
            entity.Property(e => e.ShortDes).HasMaxLength(50);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.PaslNavigation).WithMany()
                .HasForeignKey(d => d.Pasl)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WSGalleryInfoDetails_WSGalleryInfo");
        });

        modelBuilder.Entity<Wsnotice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSNotice");

            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ndetails)
                .HasMaxLength(2000)
                .HasColumnName("NDetails");
            entity.Property(e => e.NentryDate)
                .HasColumnType("datetime")
                .HasColumnName("NEntryDate");
            entity.Property(e => e.Nordering).HasColumnName("NOrdering");
            entity.Property(e => e.NpublishedDate)
                .HasColumnType("datetime")
                .HasColumnName("NPublishedDate");
            entity.Property(e => e.Nsl)
                .ValueGeneratedOnAdd()
                .HasColumnName("NSL");
            entity.Property(e => e.Nsubject)
                .HasMaxLength(50)
                .HasColumnName("NSubject");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WsnoticeAttach>(entity =>
        {
            entity.HasKey(e => e.Nsl);

            entity.ToTable("WSNoticeAttach");

            entity.Property(e => e.Nsl).HasColumnName("NSL");
            entity.Property(e => e.FileName).HasMaxLength(150);
            entity.Property(e => e.Ndetails)
                .HasMaxLength(2000)
                .HasColumnName("NDetails");
            entity.Property(e => e.NentryDate)
                .HasColumnType("datetime")
                .HasColumnName("NEntryDate");
            entity.Property(e => e.PinTop).HasColumnName("pinTop");
            entity.Property(e => e.PublishdDate).HasColumnType("date");
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<Wspage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("WSPages");

            entity.Property(e => e.PageId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PageID");
            entity.Property(e => e.Page)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WspageContent>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("WSPageContent");

            entity.Property(e => e.PageId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PageID");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TextContent).HasMaxLength(2000);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WspresidentSpeech>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSPresidentSpeech");

            entity.Property(e => e.ImagePath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresidentName).HasMaxLength(50);
            entity.Property(e => e.Psl)
                .ValueGeneratedOnAdd()
                .HasColumnName("PSL");
            entity.Property(e => e.Pspeech).HasMaxLength(1000);
        });

        modelBuilder.Entity<WsprincipalSpeech>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSPrincipalSpeech");

            entity.Property(e => e.ImagePath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrinSl)
                .ValueGeneratedOnAdd()
                .HasColumnName("PrinSL");
            entity.Property(e => e.PrincipalName).HasMaxLength(50);
            entity.Property(e => e.Prinspeech).HasMaxLength(1000);
        });

        modelBuilder.Entity<Wsslider>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("WSSlider");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WsspecialDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WSSpecialDescription");

            entity.Property(e => e.Details).HasMaxLength(4000);
            entity.Property(e => e.Dsl)
                .ValueGeneratedOnAdd()
                .HasColumnName("DSL");
            entity.Property(e => e.Dsubject)
                .HasMaxLength(150)
                .HasColumnName("DSubject");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Image).HasMaxLength(200);
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<YearInfo>(entity =>
        {
            entity.HasKey(e => e.Year);

            entity.ToTable("YearInfo");

            entity.Property(e => e.Year).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
