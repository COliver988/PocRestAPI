using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Item
{
    public long Id { get; set; }

    public long? LineItemId { get; set; }

    public string? State { get; set; }

    public int LegacyLineNumber { get; set; }

    public string? BatchNumber { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? Sla { get; set; }

    public int? PrintedOrder { get; set; }

    public string? PrunNumber { get; set; }

    public long? OrderShipmentId { get; set; }

    public virtual LineItem? LineItem { get; set; }

    public virtual ICollection<OrderShipment> OrderShipments { get; set; } = new List<OrderShipment>();
}
