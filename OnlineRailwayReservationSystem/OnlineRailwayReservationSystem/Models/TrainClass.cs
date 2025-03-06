using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class TrainClass
{
    public string TrainId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public virtual Class Class { get; set; } = null!;

    public virtual Train Train { get; set; } = null!;
}
