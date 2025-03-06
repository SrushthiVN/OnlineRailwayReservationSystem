using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Seat
{
    public string SeatId { get; set; } = null!;

    public string? CoachId { get; set; }

    public int? SeatNumber { get; set; }

    public bool? AvailabilityStatus { get; set; }

    public virtual Coach? Coach { get; set; }
}
