using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Role
{
    public string RoleId { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
