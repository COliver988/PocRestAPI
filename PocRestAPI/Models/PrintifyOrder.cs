using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyOrder
{
    public long Id { get; set; }

    public string UniqueId { get; set; } = null!;

    public bool? Sample { get; set; }

    public bool? Reprint { get; set; }

    public bool? Xqc { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? ShippingMethodId { get; set; }

    public virtual ICollection<PrintifyAddress> PrintifyAddresses { get; set; } = new List<PrintifyAddress>();

    public virtual ICollection<PrintifyEvent> PrintifyEvents { get; set; } = new List<PrintifyEvent>();

    public virtual ICollection<PrintifyItem> PrintifyItems { get; set; } = new List<PrintifyItem>();

    public virtual PrintifyShippingMethod? ShippingMethod { get; set; }
}
