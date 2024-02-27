using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class PrintifyAddress
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public string? Type { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Company { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual PrintifyOrder Order { get; set; } = null!;
}
