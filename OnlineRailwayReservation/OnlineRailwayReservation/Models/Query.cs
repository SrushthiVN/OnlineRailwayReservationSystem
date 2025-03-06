using System;
using System.Collections.Generic;

namespace OnlineRailwayReservation.Models;

public partial class Query
{
    public string QueryId { get; set; } = null!;

    public string? Keywords { get; set; }

    public virtual ICollection<QueryList> QueryLists { get; set; } = new List<QueryList>();
}
