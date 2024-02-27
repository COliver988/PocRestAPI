using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class WalmartOrder
{
    public long Id { get; set; }

    public string? PurchaseOrderId { get; set; }

    public string? CustomerOrderId { get; set; }

    public string? Status { get; set; }

    public string? CustomerEmailId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? BuyerId { get; set; }

    public string? Mart { get; set; }

    public bool? IsGuest { get; set; }

    public string? ShipMethod { get; set; }

    public List<string>? PaymentTypes { get; set; }

    public DateTime? EstimatedDelieveryDate { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public string? Details { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
