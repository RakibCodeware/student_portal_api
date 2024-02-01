using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblBuIldingName
{
    public int BuildingId { get; set; }

    public string? BuildingCode { get; set; }

    public string BuildingName { get; set; } = null!;

    public virtual ICollection<TblBuildingWithRoom> TblBuildingWithRooms { get; } = new List<TblBuildingWithRoom>();
}
