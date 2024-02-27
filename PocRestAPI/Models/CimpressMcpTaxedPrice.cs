using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpTaxedPrice
{
    public long Id { get; set; }

    public decimal? BasePrice { get; set; }

    public decimal? ShippingPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? BaseTax { get; set; }

    public decimal? ShippingTax { get; set; }

    public int? ItemId { get; set; }

    public int? ItemCustomsInformationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
