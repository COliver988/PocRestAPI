using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class ShipType
{
    public long Id { get; set; }

    public string? Provider { get; set; }

    public string? Detail { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
