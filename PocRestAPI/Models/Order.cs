using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocRestAPI.Models;

[Table("orders")]
public partial class Order
{
    public Order() {}
    public Order(JsonOrder jsonOrder)
    {
        isValid = true;
    }
    [Column("id")]
    public long Id { get; set; }

    [Column("vendor_po")]
    public string? VendorPo { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("sla")]
    public DateTime? Sla { get; set; }

    [Column("legacy_shipping_method")]
    public string? LegacyShippingMethod { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("shipping_method")]
    public string? ShippingMethod { get; set; }

    [Column("shipping_account_number")]
    public string? ShippingAccountNumber { get; set; }

    [Column("uniq_id")]
    public decimal? UniqId { get; set; }

    [Column("packing_message")]
    public string? PackingMessage { get; set; }

    [Column("postship_label_url")]
    public string? PostshipLabelUrl { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("test_order")]
    public string? TestOrder { get; set; }

    [Column("future_ship_date")]
    public DateTime? FutureShipDate { get; set; }

    [Column("distinct_id")]
    public string? DistinctId { get; set; }

    [Column("shipping_details")]
    public string? ShippingDetails { get; set; }


    public bool isValid;
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<ConsolidationBin> ConsolidationBins { get; set; } = new List<ConsolidationBin>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<LineItem> LineItems { get; set; } = new List<LineItem>();

    public virtual ICollection<OrderNotification> OrderNotifications { get; set; } = new List<OrderNotification>();
}
