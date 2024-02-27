using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpFulfillmentGroup
{
    public long Id { get; set; }

    public string? FulfillmentGroupId { get; set; }

    public string? ShortFulfillmentGroupId { get; set; }

    public string? DeliveryOptionSelectionId { get; set; }

    public string? PromisedArrivalDate { get; set; }

    public int? PreparedOrderId { get; set; }

    public int? DestinationAddressId { get; set; }

    public int? ConsigneeAddressId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public short? BusinessDays { get; set; }
}
