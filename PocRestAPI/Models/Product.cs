using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Product
{
    public long Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Specifications { get; set; }

    public string? Upc { get; set; }

    public string? CustomerItemReference { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ProductType { get; set; }

    public string? Category { get; set; }
}
