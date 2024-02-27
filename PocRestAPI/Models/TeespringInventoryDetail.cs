using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringInventoryDetail
{
    public int Id { get; set; }

    public string? Sku { get; set; }

    public int? Quantity { get; set; }

    public string? Description { get; set; }

    public int? FulfillmentJobId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
