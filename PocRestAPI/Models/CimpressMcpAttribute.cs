using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpAttribute
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public int? FulfillmentAttributeId { get; set; }

    public int? ProductManufacturingDataId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
