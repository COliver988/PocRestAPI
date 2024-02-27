using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class RedbubbleAddress
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? CountryCode { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? RedbubbleOrderId { get; set; }

    public virtual RedbubbleOrder? RedbubbleOrder { get; set; }
}
