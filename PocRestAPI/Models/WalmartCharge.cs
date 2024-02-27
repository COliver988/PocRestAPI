using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class WalmartCharge
{
    public long Id { get; set; }

    public string? ChargeType { get; set; }

    public string? ChargeName { get; set; }

    public string? Amount { get; set; }

    public string? Tax { get; set; }

    public long? ItemId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
