using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Fare
{
    public string FareId { get; set; } = null!;

    public string? ClassId { get; set; }

    public double CancelCharge48hrs { get; set; }

    public double CancelCharge12hrs { get; set; }

    public double CancelCharge4hrs { get; set; }

    public double BaseFare { get; set; }

    public double ReservationCharge { get; set; }

    public double ChargePerKm { get; set; }

    public virtual Class? Class { get; set; }
}
