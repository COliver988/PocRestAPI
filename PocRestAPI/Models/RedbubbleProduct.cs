using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class RedbubbleProduct
{
    public long Id { get; set; }

    public string? Size { get; set; }

    public string? ProductType { get; set; }

    public string? MwwCode { get; set; }

    public string? Product { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public decimal? Weight { get; set; }

    public string? BodyColor { get; set; }

    public string? PrintLocation { get; set; }

    public virtual ICollection<RedbubbleItem> RedbubbleItems { get; set; } = new List<RedbubbleItem>();
}
