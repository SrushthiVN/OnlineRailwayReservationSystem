using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Train
{
    public string TrainId { get; set; } = null!;

    public string TrainNumber { get; set; } = null!;

    public string TrainName { get; set; } = null!;

    public int TotalSeats { get; set; }

    public string? RunningDay { get; set; }

    public string Route { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
