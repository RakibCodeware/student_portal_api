using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblExamMonthlyTestDetail
{
    public int MonthlyTestId { get; set; }

    public long? StudentId { get; set; }

    public long? RollNo { get; set; }

    public double? Obtainmarks { get; set; }

    public virtual TblExamMontlyTest MonthlyTest { get; set; } = null!;
}
