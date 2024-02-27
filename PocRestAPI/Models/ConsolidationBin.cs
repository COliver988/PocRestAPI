using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class ConsolidationBin
{
    public long Id { get; set; }

    public int? BinNumber { get; set; }

    public long? OrderId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Location { get; set; }

    public int? TotalItems { get; set; }

    public int? Consolidated { get; set; }

    public int? Printed { get; set; }

    public int? Pressed { get; set; }

    public int? Cancelled { get; set; }

    public DateTime? LastItemUpdatedAt { get; set; }

    public virtual Order? Order { get; set; }
}
