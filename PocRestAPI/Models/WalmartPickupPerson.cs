using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class WalmartPickupPerson
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public long? OrderId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
