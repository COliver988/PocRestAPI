using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringRecipient
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? CountryCode { get; set; }

    public string? PostalCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public int? ShipmentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
