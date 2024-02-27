using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Box
{
    public long Id { get; set; }

    public string? LegacyBoxId { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public decimal? Weight { get; set; }
}
