using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class ReservationDetail
{
    public string ReservationId { get; set; } = null!;

    public string TicketId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Age { get; set; }

    public string Address { get; set; } = null!;

    public string PaymentId { get; set; } = null!;

    public virtual Payment Payment { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
