using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpPhysicalAddress
{
    public long Id { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string? StateOrProvince { get; set; }

    public string? City { get; set; }

    public string? Company { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public string? PhoneExt { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public int? FulfillmentGroupId { get; set; }

    public int? ShippingLabelDetailId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Email { get; set; }
}
