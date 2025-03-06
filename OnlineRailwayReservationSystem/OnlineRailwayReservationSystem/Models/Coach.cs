using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Coach
{
    public string CoachId { get; set; } = null!;

    public string? ClassId { get; set; }

    public string CoachNumber { get; set; } = null!;

    public virtual Class? Class { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();
}
