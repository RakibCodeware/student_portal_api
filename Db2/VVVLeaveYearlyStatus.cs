using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class VVVLeaveYearlyStatus
{
    public long Eid { get; set; }

    public string? Ename { get; set; }

    public long? EcardNo { get; set; }

    public int? ClSpend { get; set; }

    public short? ClTotal { get; set; }

    public int? ClRemaining { get; set; }

    public int? SlSpend { get; set; }

    public short? SlTotal { get; set; }

    public int? SlRemaining { get; set; }

    public int? AlSpend { get; set; }

    public short? AlTotal { get; set; }

    public int? AlRemaining { get; set; }

    public int? MlSpend { get; set; }

    public short? MlTotal { get; set; }

    public int? MlRemaining { get; set; }

    public int? OplSpend { get; set; }

    public short? OplTotal { get; set; }

    public int? OplRemaining { get; set; }

    public int? OlSpend { get; set; }

    public short? OlTotal { get; set; }

    public int? OlRemaining { get; set; }

    public short? Did { get; set; }

    public string? Dname { get; set; }

    public short? DesId { get; set; }

    public string? DesName { get; set; }

    public short? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public string? Year { get; set; }
}
