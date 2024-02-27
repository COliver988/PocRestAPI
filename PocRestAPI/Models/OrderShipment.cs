using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class OrderShipment
{
    public long Id { get; set; }

    public string? TrackingNumber { get; set; }

    public long? ItemId { get; set; }

    public string? BoxId { get; set; }

    public double? Weight { get; set; }

    public double? Freight { get; set; }

    public string? BoxItemIds { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ShipmentNumber { get; set; }

    public string? TrackingUrl { get; set; }

    public string? CarrierId { get; set; }

    public string? CarrierService { get; set; }

    public DateTime? EstDeliveryDate { get; set; }

    public decimal? PostageFee { get; set; }

    public decimal? LabelFee { get; set; }

    public long? OrderId { get; set; }

    public string? ShippoObjectId { get; set; }

    public virtual Item? Item { get; set; }
}
