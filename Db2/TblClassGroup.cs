using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblClassGroup
{
    public short ClsGrpId { get; set; }

    public short? ClassId { get; set; }

    public short? GroupId { get; set; }

    public int? NumofMandatorySub { get; set; }

    public virtual Class? Class { get; set; }

    public virtual TblGroup? Group { get; set; }
}
