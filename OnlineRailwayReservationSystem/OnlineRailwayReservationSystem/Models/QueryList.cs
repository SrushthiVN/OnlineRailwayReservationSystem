using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class QueryList
{
    public string QueryListId { get; set; } = null!;

    public string? QueryId { get; set; }

    public string? QueryDescription { get; set; }

    public virtual Query? Query { get; set; }

    public virtual ICollection<Support> Supports { get; set; } = new List<Support>();
}
