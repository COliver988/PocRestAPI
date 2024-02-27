using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringArtwork
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? Png { get; set; }

    public string? Eps { get; set; }

    public string? Pdf { get; set; }

    public List<string>? Inks { get; set; }

    public int? FulfillmentJobId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
