using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Payment
{
    public string PaymentId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string TicketId { get; set; } = null!;

    public double Amount { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } = new List<ReservationDetail>();

    public virtual Ticket Ticket { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
