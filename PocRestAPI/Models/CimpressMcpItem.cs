using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpItem
{
    public long Id { get; set; }

    public string? ItemId { get; set; }

    public string? ShortItemId { get; set; }

    public string? MerchantItemId { get; set; }

    public string? SkuCode { get; set; }

    public int? Quantity { get; set; }

    public string? MerchantProductName { get; set; }

    public string? ItemPreviewUrl { get; set; }

    public string? ManufacturingReadyDataUrl { get; set; }

    public int? FulfillmentGroupId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string ShippingDetails { get; set; } = null!;
}
