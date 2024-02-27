using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class RedbubbleOrder
{
    public long Id { get; set; }

    public string? CallbackUrl { get; set; }

    public string? VendorPo { get; set; }

    public string? ShippingMethod { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? OrderType { get; set; }

    public virtual ICollection<RedbubbleAddress> RedbubbleAddresses { get; set; } = new List<RedbubbleAddress>();

    public virtual ICollection<RedbubbleItem> RedbubbleItems { get; set; } = new List<RedbubbleItem>();
}
