using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyItem
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public string UniqueId { get; set; } = null!;

    public long ProductId { get; set; }

    public int Quantity { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ItemProperties { get; set; }

    public virtual PrintifyOrder Order { get; set; } = null!;

    public virtual ICollection<PrintifyImage> PrintifyImages { get; set; } = new List<PrintifyImage>();

    public virtual PrintifyProduct Product { get; set; } = null!;
}
