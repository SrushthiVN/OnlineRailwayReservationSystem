﻿using System;
using System.Collections.Generic;

namespace OnlineRailwayReservationSystem.Models;

public partial class Quotum
{
    public string QuotaId { get; set; } = null!;

    public string QuotaType { get; set; } = null!;

    public int AgeLimit { get; set; }
}
