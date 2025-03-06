using System;
using System.Collections.Generic;

namespace OnlineRailwayReservation.Models;

public partial class Route
{
    public string RouteId { get; set; } = null!;

    public string? Source { get; set; }

    public TimeOnly? Departure { get; set; }

    public string? Destination { get; set; }

    public TimeOnly? Arrival { get; set; }

    public int Distance { get; set; }

    public string Duration { get; set; } = null!;
}
