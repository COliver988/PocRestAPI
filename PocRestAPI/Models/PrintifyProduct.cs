using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyProduct
{
    public long Id { get; set; }

    public string? Sku { get; set; }

    public string? MwwProductCode { get; set; }

    public int? Stock { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? BlankPrice { get; set; }

    public int? ProcessingPrice { get; set; }

    public int? PrintingPrice { get; set; }

    public int? CountryCode { get; set; }

    public virtual ICollection<PrintifyItem> PrintifyItems { get; set; } = new List<PrintifyItem>();
}
