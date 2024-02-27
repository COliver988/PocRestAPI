using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class WalmartItem
{
    public long Id { get; set; }

    public string? ReferenceLineId { get; set; }

    public int? LineNumber { get; set; }

    public int? Quantity { get; set; }

    public string? ProductName { get; set; }

    public string? Sku { get; set; }

    public string? ImageUrl { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightUnit { get; set; }

    public string? Contents { get; set; }

    public long? OrderId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
