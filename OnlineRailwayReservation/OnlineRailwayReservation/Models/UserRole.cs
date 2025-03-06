using System;
using System.Collections.Generic;

namespace OnlineRailwayReservation.Models;

public partial class UserRole
{
    public string UserId { get; set; } = null!;

    public string? RoleId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User User { get; set; } = null!;
}
