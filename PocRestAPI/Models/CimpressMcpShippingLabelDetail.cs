using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpShippingLabelDetail
{
    public long Id { get; set; }

    public string? MerchantDisplayName { get; set; }

    public string? MerchantShippingReference { get; set; }

    public int? FulfillmentGroupId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
