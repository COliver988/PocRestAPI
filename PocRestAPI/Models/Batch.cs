using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Batch
{
    public string BatchNumber { get; set; } = null!;

    public int? TotalItems { get; set; }

    public int? Printed { get; set; }

    public int? Pressed { get; set; }

    public int? Consolidated { get; set; }

    public int? Cancelled { get; set; }

    public int? Other { get; set; }

    public decimal? PercentComplete { get; set; }

    public DateTime? OldestSla { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
