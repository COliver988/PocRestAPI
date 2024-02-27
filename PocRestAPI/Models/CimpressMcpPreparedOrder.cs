using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpPreparedOrder
{
    public long Id { get; set; }

    public string? OrderId { get; set; }

    public string? CreatedDate { get; set; }

    public string? MerchantCustomerId { get; set; }

    public string? TaxpayerIdentification { get; set; }

    public string? LanguageId { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantOrderId { get; set; }

    public bool? FakeOrder { get; set; }

    public bool? DoNotProduce { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ExpectedShipDate { get; set; }

    public string? ExpectedCarrierService { get; set; }
}
