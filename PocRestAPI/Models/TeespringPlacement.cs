using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringPlacement
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public int? XOffset { get; set; }

    public int? YOffset { get; set; }

    public string? AlignmentType { get; set; }

    public int? FulfillmentJobId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
