using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringShippingLabel
{
    public int Id { get; set; }

    public string? ShipperReference { get; set; }

    public string? Carrier { get; set; }

    public string? LabelZpl { get; set; }

    public string? TrackingNumber { get; set; }

    public string? LabelErrors { get; set; }

    public int? ShipmentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
