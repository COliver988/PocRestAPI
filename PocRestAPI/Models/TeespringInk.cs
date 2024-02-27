using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringInk
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? Hex { get; set; }

    public string? FullName { get; set; }

    public int? FulfillmentJobId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
