using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class WalmartFulfillment
{
    public long Id { get; set; }

    public string? FulfillmentOption { get; set; }

    public string? ShipMethod { get; set; }

    public string? StoreId { get; set; }

    public string? OfferId { get; set; }

    public DateTime? PickUpDate { get; set; }

    public DateTime? PickUpBy { get; set; }

    public string? OriginalCarrierMethod { get; set; }

    public string? Delivery { get; set; }

    public long? ItemId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
