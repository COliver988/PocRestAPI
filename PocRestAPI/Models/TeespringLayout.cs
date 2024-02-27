using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringLayout
{
    public int Id { get; set; }

    public string? ArtworkToken { get; set; }

    public string? MockupToken { get; set; }

    public string? PlacementToken { get; set; }

    public string? Location { get; set; }

    public int? InventoryDetailId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
