using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Address
{
    public long Id { get; set; }

    public long? OrderId { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Address2 { get; set; }

    public string? Company { get; set; }

    public virtual Order? Order { get; set; }
}
