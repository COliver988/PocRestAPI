using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class BinStatus
{
    public int? BinNumber { get; set; }

    public string? BinLocation { get; set; }

    public long? TotalItems { get; set; }

    public long? Pressed { get; set; }

    public long? Cancelled { get; set; }

    public bool? SeemsComplete { get; set; }

    public bool? HasCancelledItems { get; set; }

    public bool? AllItemsCancelled { get; set; }

    public TimeSpan? TimeSinceLastItemUpdated { get; set; }

    public long? Printed { get; set; }

    public long? Shipped { get; set; }

    public long? Other { get; set; }
}
