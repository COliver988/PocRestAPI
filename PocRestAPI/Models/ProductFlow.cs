using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class ProductFlow
{
    public long Id { get; set; }

    public int FlowNumber { get; set; }

    public string? Flows { get; set; }

    public string? FlowSequence { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
