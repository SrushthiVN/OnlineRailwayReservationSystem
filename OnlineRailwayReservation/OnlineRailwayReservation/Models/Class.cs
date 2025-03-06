using System;
using System.Collections.Generic;

namespace OnlineRailwayReservation.Models;

public partial class Class
{
    public string ClassId { get; set; } = null!;

    public string ClassType { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public int AvailableSeats { get; set; }

    public virtual ICollection<Coach> Coaches { get; set; } = new List<Coach>();

    public virtual ICollection<Fare> Fares { get; set; } = new List<Fare>();
}
