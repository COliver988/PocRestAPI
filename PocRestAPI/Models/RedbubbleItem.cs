using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class RedbubbleItem
{
    public long Id { get; set; }

    public int? Quantity { get; set; }

    public string? ItemPo { get; set; }

    public string? FrontImage { get; set; }

    public string? BackImage { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? RedbubbleOrderId { get; set; }

    public long? RedbubbleProductId { get; set; }

    public string? State { get; set; }

    public string? PricingInformation { get; set; }

    public virtual RedbubbleOrder? RedbubbleOrder { get; set; }

    public virtual RedbubbleProduct? RedbubbleProduct { get; set; }
}
