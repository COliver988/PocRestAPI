using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyEvent
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public string? Action { get; set; }

    public List<string>? AffectedItems { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Details { get; set; }

    public virtual PrintifyOrder Order { get; set; } = null!;
}
