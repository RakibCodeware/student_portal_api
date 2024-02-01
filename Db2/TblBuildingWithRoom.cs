using System;
using System.Collections.Generic;

namespace EduPortalAPI.Db2;

public partial class TblBuildingWithRoom
{
    public int RoomId { get; set; }

    public string? RoomCode { get; set; }

    public string RoomName { get; set; } = null!;

    public int RoomCapacity { get; set; }

    public int BuildingId { get; set; }

    public virtual TblBuIldingName Building { get; set; } = null!;
}
