using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyShippingMethod
{
    public long Id { get; set; }

    public string? Carrier { get; set; }

    public string? Priority { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<PrintifyOrder> PrintifyOrders { get; set; } = new List<PrintifyOrder>();
}
