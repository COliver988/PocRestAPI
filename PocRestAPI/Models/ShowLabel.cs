using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class ShowLabel
{
    public long Id { get; set; }

    public string? Style { get; set; }

    public string? StyleDesc { get; set; }

    public string? PriceA { get; set; }

    public string? Unit { get; set; }

    public int? StyleUdf02 { get; set; }

    public string? Upc { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
