using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpItemCustomsInformation
{
    public long Id { get; set; }

    public string? OriginalOrderId { get; set; }

    public string? OriginalItemId { get; set; }

    public int? ItemId { get; set; }

    public int? ListPriceId { get; set; }

    public int? PricePaidId { get; set; }

    public int? AverageIdenticalItemPriceId { get; set; }

    public int? AverageSimilarItemPriceId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
