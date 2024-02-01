using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VExamSubjectWiseResultAnalysis
{
    public int SubId { get; set; }

    public int CourseId { get; set; }

    public string SubName { get; set; } = null!;

    public int IsOptional { get; set; }

    public int NumberOfStudent { get; set; }

    public int Passed { get; set; }

    public int Failed { get; set; }

    public int HighestMarks { get; set; }

    public int D { get; set; }

    public int C { get; set; }

    public int B { get; set; }

    public int A { get; set; }

    public int A1 { get; set; }

    public int A2 { get; set; }

    public int Aa { get; set; }
}
