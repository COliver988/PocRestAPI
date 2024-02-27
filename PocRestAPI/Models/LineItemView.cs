using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class LineItemView
{
    public long? Id { get; set; }

    public long? OrderId { get; set; }

    public int? LineNumber { get; set; }

    public string? ProductUpc { get; set; }

    public int? Quantity { get; set; }

    public string? CustomerLineNumber { get; set; }

    public string? ItemProperties { get; set; }

    public string? Description { get; set; }

    public string? State { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Po { get; set; }

    public string? Meta { get; set; }
}
