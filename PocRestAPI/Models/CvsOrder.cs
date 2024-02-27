using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CvsOrder
{
    public long Id { get; set; }

    public string? VendorOrderId { get; set; }

    public string? VendorId { get; set; }

    public string? VendorConsumerId { get; set; }

    public string? VendorUnitId { get; set; }

    public string? OutletId { get; set; }

    public string? AddressId { get; set; }

    public string? ConsumerAddressId { get; set; }

    public string? ShipMethod { get; set; }

    public string? FulfillmentOptions { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? State { get; set; }

    public string? FileId { get; set; }

    public string? PackingListPath { get; set; }

    public string? StoreId { get; set; }

    public decimal? TotalPrice { get; set; }
}
