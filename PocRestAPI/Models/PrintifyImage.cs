using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyImage
{
    public long Id { get; set; }

    public long ItemId { get; set; }

    public string? PrintLocation { get; set; }

    public string? Type { get; set; }

    public string? Url { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual PrintifyItem Item { get; set; } = null!;
}
