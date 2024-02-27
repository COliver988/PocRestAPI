using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CvsItem
{
    public long Id { get; set; }

    public int? OrderLineId { get; set; }

    public int? Quantity { get; set; }

    public string? ProductCode { get; set; }

    public string? Price { get; set; }

    public long? OrderId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ProductDescription { get; set; }
}
