using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringMockup
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? Url { get; set; }

    public int? FulfillmentJobId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
