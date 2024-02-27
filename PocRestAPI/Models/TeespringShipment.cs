using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringShipment
{
    public int Id { get; set; }

    public string? ShipperReference { get; set; }

    public int? ShippingWeight { get; set; }

    public int? FulfillmentJobId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
