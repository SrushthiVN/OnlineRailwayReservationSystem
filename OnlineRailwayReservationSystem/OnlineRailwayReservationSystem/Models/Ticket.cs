using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Ticket
{
    public string TicketId { get; set; } = null!;

    public string? UserId { get; set; }

    public string? TrainId { get; set; }

    public string Pnr { get; set; } = null!;

    public TimeOnly Duration { get; set; }

    public string SourceStation { get; set; } = null!;

    public string DestinationStation { get; set; } = null!;

    public string TicketStatus { get; set; } = null!;

    public double TotalFare { get; set; }

    public DateTime JourneyStartDate { get; set; }

    public DateTime JourneyEndDate { get; set; }

    public string SeatNumber { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string Coach { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } = new List<ReservationDetail>();

    public virtual Train? Train { get; set; }

    public virtual User? User { get; set; }
}
