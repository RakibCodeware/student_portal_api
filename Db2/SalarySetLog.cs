using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class SalarySetLog
{
    public long SaLid { get; set; }

    public long? SaId { get; set; }

    public long? Eid { get; set; }

    public decimal? SaLnewSaGovt { get; set; }

    public decimal? SaLoldSaGovt { get; set; }

    public decimal? SaLnewSaSchool { get; set; }

    public decimal? SaLsaOldSchool { get; set; }

    public DateTime? SaLdate { get; set; }

    public int? SaLchangedBy { get; set; }
}
