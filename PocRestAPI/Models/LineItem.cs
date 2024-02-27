using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class LineItem
{
    public long Id { get; set; }

    public long? OrderId { get; set; }

    public int LineNumber { get; set; }

    public string? ProductUpc { get; set; }

    public int Quantity { get; set; }

    public string? CustomerProductCode { get; set; }

    public string? CustomerLineNumber { get; set; }

    public string? ItemProperties { get; set; }

    public string? Description { get; set; }

    public string? State { get; set; }

    public string? Co { get; set; }

    public string Po { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? MoNumber { get; set; }

    public string? KitData { get; set; }

    public string? ProductCode { get; set; }

    public string? SpecificationId { get; set; }

    public string? VendorItemPo { get; set; }

    public string? CustomerUpc { get; set; }

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Order? Order { get; set; }
}
