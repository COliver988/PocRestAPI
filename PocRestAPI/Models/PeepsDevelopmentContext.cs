using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PocRestAPI.Models;

public partial class PeepsDevelopmentContext : DbContext
{
    public PeepsDevelopmentContext()
    {
    }

    public PeepsDevelopmentContext(DbContextOptions<PeepsDevelopmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveStorageAttachment> ActiveStorageAttachments { get; set; }

    public virtual DbSet<ActiveStorageBlob> ActiveStorageBlobs { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<BinStatus> BinStatuses { get; set; }

    public virtual DbSet<Box> Boxes { get; set; }

    public virtual DbSet<CimpressMcpAttribute> CimpressMcpAttributes { get; set; }

    public virtual DbSet<CimpressMcpContact> CimpressMcpContacts { get; set; }

    public virtual DbSet<CimpressMcpFulfillmentGroup> CimpressMcpFulfillmentGroups { get; set; }

    public virtual DbSet<CimpressMcpItem> CimpressMcpItems { get; set; }

    public virtual DbSet<CimpressMcpItemCustomsInformation> CimpressMcpItemCustomsInformations { get; set; }

    public virtual DbSet<CimpressMcpPhysicalAddress> CimpressMcpPhysicalAddresses { get; set; }

    public virtual DbSet<CimpressMcpPreparedOrder> CimpressMcpPreparedOrders { get; set; }

    public virtual DbSet<CimpressMcpPrice> CimpressMcpPrices { get; set; }

    public virtual DbSet<CimpressMcpShippingLabelDetail> CimpressMcpShippingLabelDetails { get; set; }

    public virtual DbSet<CimpressMcpTaxedPrice> CimpressMcpTaxedPrices { get; set; }

    public virtual DbSet<ConsolidationBin> ConsolidationBins { get; set; }

    public virtual DbSet<CvsAddress> CvsAddresses { get; set; }

    public virtual DbSet<CvsAsset> CvsAssets { get; set; }

    public virtual DbSet<CvsItem> CvsItems { get; set; }

    public virtual DbSet<CvsOrder> CvsOrders { get; set; }

    public virtual DbSet<Design> Designs { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<LineItemCount> LineItemCounts { get; set; }

    public virtual DbSet<LineItemView> LineItemViews { get; set; }

    public virtual DbSet<LoggerDatum> LoggerData { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderNotification> OrderNotifications { get; set; }

    public virtual DbSet<OrderShipment> OrderShipments { get; set; }

    public virtual DbSet<Printer> Printers { get; set; }

    public virtual DbSet<PrintifyAddress> PrintifyAddresses { get; set; }

    public virtual DbSet<PrintifyEvent> PrintifyEvents { get; set; }

    public virtual DbSet<PrintifyImage> PrintifyImages { get; set; }

    public virtual DbSet<PrintifyItem> PrintifyItems { get; set; }

    public virtual DbSet<PrintifyOrder> PrintifyOrders { get; set; }

    public virtual DbSet<PrintifyProduct> PrintifyProducts { get; set; }

    public virtual DbSet<PrintifyShippingMethod> PrintifyShippingMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductFlow> ProductFlows { get; set; }

    public virtual DbSet<RedbubbleAddress> RedbubbleAddresses { get; set; }

    public virtual DbSet<RedbubbleItem> RedbubbleItems { get; set; }

    public virtual DbSet<RedbubbleOrder> RedbubbleOrders { get; set; }

    public virtual DbSet<RedbubbleProduct> RedbubbleProducts { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

    public virtual DbSet<SeriLog> SeriLogs { get; set; }

    public virtual DbSet<ShipType> ShipTypes { get; set; }

    public virtual DbSet<ShowLabel> ShowLabels { get; set; }

    public virtual DbSet<TeespringArtwork> TeespringArtworks { get; set; }

    public virtual DbSet<TeespringFulfillmentJob> TeespringFulfillmentJobs { get; set; }

    public virtual DbSet<TeespringInk> TeespringInks { get; set; }

    public virtual DbSet<TeespringInventoryDetail> TeespringInventoryDetails { get; set; }

    public virtual DbSet<TeespringInventoryItem> TeespringInventoryItems { get; set; }

    public virtual DbSet<TeespringLayout> TeespringLayouts { get; set; }

    public virtual DbSet<TeespringMockup> TeespringMockups { get; set; }

    public virtual DbSet<TeespringPlacement> TeespringPlacements { get; set; }

    public virtual DbSet<TeespringRecipient> TeespringRecipients { get; set; }

    public virtual DbSet<TeespringShipment> TeespringShipments { get; set; }

    public virtual DbSet<TeespringShippingLabel> TeespringShippingLabels { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<VersionAssociation> VersionAssociations { get; set; }

    public virtual DbSet<WalmartAddress> WalmartAddresses { get; set; }

    public virtual DbSet<WalmartCharge> WalmartCharges { get; set; }

    public virtual DbSet<WalmartFulfillment> WalmartFulfillments { get; set; }

    public virtual DbSet<WalmartItem> WalmartItems { get; set; }

    public virtual DbSet<WalmartOrder> WalmartOrders { get; set; }

    public virtual DbSet<WalmartPickupPerson> WalmartPickupPeople { get; set; }

    public virtual DbSet<Webhook> Webhooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("USER ID=postgres; Password=PGPassword_1; Server=localhost; Port=5432; Database=peeps_development; SearchPath=mww_ondemand_api; Pooling=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveStorageAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_attachments_pkey");

            entity.ToTable("active_storage_attachments", "mww_ondemand_api");

            entity.HasIndex(e => e.BlobId, "index_active_storage_attachments_on_blob_id");

            entity.HasIndex(e => new { e.RecordType, e.RecordId, e.Name, e.BlobId }, "index_active_storage_attachments_uniqueness").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('active_storage_attachments_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BlobId).HasColumnName("blob_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.RecordId).HasColumnName("record_id");
            entity.Property(e => e.RecordType)
                .HasColumnType("character varying")
                .HasColumnName("record_type");

            entity.HasOne(d => d.Blob).WithMany(p => p.ActiveStorageAttachments)
                .HasForeignKey(d => d.BlobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_c3b3935057");
        });

        modelBuilder.Entity<ActiveStorageBlob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_blobs_pkey");

            entity.ToTable("active_storage_blobs", "mww_ondemand_api");

            entity.HasIndex(e => e.Key, "index_active_storage_blobs_on_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('active_storage_blobs_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ByteSize).HasColumnName("byte_size");
            entity.Property(e => e.Checksum)
                .HasColumnType("character varying")
                .HasColumnName("checksum");
            entity.Property(e => e.ContentType)
                .HasColumnType("character varying")
                .HasColumnName("content_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Filename)
                .HasColumnType("character varying")
                .HasColumnName("filename");
            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addresses_pkey");

            entity.ToTable("addresses", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_addresses_on_order_id");

            entity.HasIndex(e => e.Type, "index_addresses_on_type");

            entity.HasIndex(e => new { e.Type, e.OrderId }, "index_addresses_on_type_and_order_id").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("character varying")
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasColumnType("character varying")
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasColumnType("character varying")
                .HasColumnName("company");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("fk_rails_27d0ce0437");
        });

        modelBuilder.Entity<ArInternalMetadatum>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("ar_internal_metadata_pkey");

            entity.ToTable("ar_internal_metadata", "mww_ondemand_api");

            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasColumnType("character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Batch>(entity =>
        {
            entity.HasKey(e => e.BatchNumber).HasName("batches_pkey");

            entity.ToTable("batches", "mww_ondemand_api");

            entity.Property(e => e.BatchNumber)
                .HasColumnType("character varying")
                .HasColumnName("batch_number");
            entity.Property(e => e.Cancelled)
                .HasDefaultValue(0)
                .HasColumnName("cancelled");
            entity.Property(e => e.Consolidated)
                .HasDefaultValue(0)
                .HasColumnName("consolidated");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OldestSla)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("oldest_sla");
            entity.Property(e => e.Other)
                .HasDefaultValue(0)
                .HasColumnName("other");
            entity.Property(e => e.PercentComplete)
                .HasPrecision(4, 1)
                .HasDefaultValueSql("0.0")
                .HasColumnName("percent_complete");
            entity.Property(e => e.Pressed)
                .HasDefaultValue(0)
                .HasColumnName("pressed");
            entity.Property(e => e.Printed)
                .HasDefaultValue(0)
                .HasColumnName("printed");
            entity.Property(e => e.TotalItems)
                .HasDefaultValue(0)
                .HasColumnName("total_items");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BinStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bin_statuses", "mww_ondemand_api");

            entity.Property(e => e.AllItemsCancelled).HasColumnName("all_items_cancelled");
            entity.Property(e => e.BinLocation)
                .HasColumnType("character varying")
                .HasColumnName("bin_location");
            entity.Property(e => e.BinNumber).HasColumnName("bin_number");
            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.HasCancelledItems).HasColumnName("has_cancelled_items");
            entity.Property(e => e.Other).HasColumnName("other");
            entity.Property(e => e.Pressed).HasColumnName("pressed");
            entity.Property(e => e.Printed).HasColumnName("printed");
            entity.Property(e => e.SeemsComplete).HasColumnName("seems_complete");
            entity.Property(e => e.Shipped).HasColumnName("shipped");
            entity.Property(e => e.TimeSinceLastItemUpdated).HasColumnName("time_since_last_item_updated");
            entity.Property(e => e.TotalItems).HasColumnName("total_items");
        });

        modelBuilder.Entity<Box>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("boxes_pkey");

            entity.ToTable("boxes", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('boxes_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Height)
                .HasPrecision(4, 2)
                .HasColumnName("height");
            entity.Property(e => e.LegacyBoxId)
                .HasColumnType("character varying")
                .HasColumnName("legacy_box_id");
            entity.Property(e => e.Length)
                .HasPrecision(4, 2)
                .HasColumnName("length");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weight)
                .HasPrecision(4, 2)
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasPrecision(4, 2)
                .HasColumnName("width");
        });

        modelBuilder.Entity<CimpressMcpAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_attributes_pkey");

            entity.ToTable("cimpress_mcp_attributes", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_attributes_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentAttributeId).HasColumnName("fulfillment_attribute_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ProductManufacturingDataId).HasColumnName("product_manufacturing_data_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasColumnType("character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CimpressMcpContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_contacts_pkey");

            entity.ToTable("cimpress_mcp_contacts", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_contacts_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.PreparedOrderId).HasColumnName("prepared_order_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpFulfillmentGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_fulfillment_groups_pkey");

            entity.ToTable("cimpress_mcp_fulfillment_groups", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_fulfillment_groups_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BusinessDays).HasColumnName("business_days");
            entity.Property(e => e.ConsigneeAddressId).HasColumnName("consignee_address_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeliveryOptionSelectionId)
                .HasColumnType("character varying")
                .HasColumnName("delivery_option_selection_id");
            entity.Property(e => e.DestinationAddressId).HasColumnName("destination_address_id");
            entity.Property(e => e.FulfillmentGroupId)
                .HasColumnType("character varying")
                .HasColumnName("fulfillment_group_id");
            entity.Property(e => e.PreparedOrderId).HasColumnName("prepared_order_id");
            entity.Property(e => e.PromisedArrivalDate)
                .HasColumnType("character varying")
                .HasColumnName("promised_arrival_date");
            entity.Property(e => e.ShortFulfillmentGroupId)
                .HasColumnType("character varying")
                .HasColumnName("short_fulfillment_group_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_items_pkey");

            entity.ToTable("cimpress_mcp_items", "mww_ondemand_api");

            entity.HasIndex(e => e.ShippingDetails, "index_cimpress_mcp_items_on_shipping_details").HasMethod("gin");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_items_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentGroupId).HasColumnName("fulfillment_group_id");
            entity.Property(e => e.ItemId)
                .HasColumnType("character varying")
                .HasColumnName("item_id");
            entity.Property(e => e.ItemPreviewUrl)
                .HasColumnType("character varying")
                .HasColumnName("item_preview_url");
            entity.Property(e => e.ManufacturingReadyDataUrl)
                .HasColumnType("character varying")
                .HasColumnName("manufacturing_ready_data_url");
            entity.Property(e => e.MerchantItemId)
                .HasColumnType("character varying")
                .HasColumnName("merchant_item_id");
            entity.Property(e => e.MerchantProductName)
                .HasColumnType("character varying")
                .HasColumnName("merchant_product_name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ShippingDetails)
                .HasDefaultValueSql("'\"{}\"'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("shipping_details");
            entity.Property(e => e.ShortItemId)
                .HasColumnType("character varying")
                .HasColumnName("short_item_id");
            entity.Property(e => e.SkuCode)
                .HasColumnType("character varying")
                .HasColumnName("sku_code");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpItemCustomsInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_item_customs_informations_pkey");

            entity.ToTable("cimpress_mcp_item_customs_informations", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_item_customs_informations_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AverageIdenticalItemPriceId).HasColumnName("average_identical_item_price_id");
            entity.Property(e => e.AverageSimilarItemPriceId).HasColumnName("average_similar_item_price_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ListPriceId).HasColumnName("list_price_id");
            entity.Property(e => e.OriginalItemId)
                .HasColumnType("character varying")
                .HasColumnName("original_item_id");
            entity.Property(e => e.OriginalOrderId)
                .HasColumnType("character varying")
                .HasColumnName("original_order_id");
            entity.Property(e => e.PricePaidId).HasColumnName("price_paid_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpPhysicalAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_physical_addresses_pkey");

            entity.ToTable("cimpress_mcp_physical_addresses", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_physical_addresses_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasColumnType("character varying")
                .HasColumnName("company");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.FulfillmentGroupId).HasColumnName("fulfillment_group_id");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasColumnType("character varying")
                .HasColumnName("middle_name");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.PhoneExt)
                .HasColumnType("character varying")
                .HasColumnName("phone_ext");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.ShippingLabelDetailId).HasColumnName("shipping_label_detail_id");
            entity.Property(e => e.StateOrProvince)
                .HasColumnType("character varying")
                .HasColumnName("state_or_province");
            entity.Property(e => e.Street1)
                .HasColumnType("character varying")
                .HasColumnName("street1");
            entity.Property(e => e.Street2)
                .HasColumnType("character varying")
                .HasColumnName("street2");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpPreparedOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_prepared_orders_pkey");

            entity.ToTable("cimpress_mcp_prepared_orders", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_prepared_orders_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("character varying")
                .HasColumnName("created_date");
            entity.Property(e => e.DoNotProduce).HasColumnName("do_not_produce");
            entity.Property(e => e.ExpectedCarrierService)
                .HasColumnType("character varying")
                .HasColumnName("expected_carrier_service");
            entity.Property(e => e.ExpectedShipDate)
                .HasColumnType("character varying")
                .HasColumnName("expected_ship_date");
            entity.Property(e => e.FakeOrder).HasColumnName("fake_order");
            entity.Property(e => e.LanguageId)
                .HasColumnType("character varying")
                .HasColumnName("language_id");
            entity.Property(e => e.MerchantCustomerId)
                .HasColumnType("character varying")
                .HasColumnName("merchant_customer_id");
            entity.Property(e => e.MerchantId)
                .HasColumnType("character varying")
                .HasColumnName("merchant_id");
            entity.Property(e => e.MerchantOrderId)
                .HasColumnType("character varying")
                .HasColumnName("merchant_order_id");
            entity.Property(e => e.OrderId)
                .HasColumnType("character varying")
                .HasColumnName("order_id");
            entity.Property(e => e.TaxpayerIdentification)
                .HasColumnType("character varying")
                .HasColumnName("taxpayer_identification");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_prices_pkey");

            entity.ToTable("cimpress_mcp_prices", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_prices_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BasePrice)
                .HasPrecision(10, 4)
                .HasColumnName("base_price");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrencyCode)
                .HasColumnType("character varying")
                .HasColumnName("currency_code");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ShippingPrice)
                .HasPrecision(10, 4)
                .HasColumnName("shipping_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpShippingLabelDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_shipping_label_details_pkey");

            entity.ToTable("cimpress_mcp_shipping_label_details", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_shipping_label_details_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentGroupId).HasColumnName("fulfillment_group_id");
            entity.Property(e => e.MerchantDisplayName)
                .HasColumnType("character varying")
                .HasColumnName("merchant_display_name");
            entity.Property(e => e.MerchantShippingReference)
                .HasColumnType("character varying")
                .HasColumnName("merchant_shipping_reference");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CimpressMcpTaxedPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cimpress_mcp_taxed_prices_pkey");

            entity.ToTable("cimpress_mcp_taxed_prices", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cimpress_mcp_taxed_prices_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BasePrice)
                .HasPrecision(10, 4)
                .HasColumnName("base_price");
            entity.Property(e => e.BaseTax)
                .HasPrecision(8, 4)
                .HasColumnName("base_tax");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrencyCode)
                .HasColumnType("character varying")
                .HasColumnName("currency_code");
            entity.Property(e => e.ItemCustomsInformationId).HasColumnName("item_customs_information_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ShippingPrice)
                .HasPrecision(10, 4)
                .HasColumnName("shipping_price");
            entity.Property(e => e.ShippingTax)
                .HasPrecision(8, 4)
                .HasColumnName("shipping_tax");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ConsolidationBin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("consolidation_bins_pkey");

            entity.ToTable("consolidation_bins", "mww_ondemand_api");

            entity.HasIndex(e => new { e.BinNumber, e.Location }, "consolidation_bins_by_unique_location_and_bin_number").IsUnique();

            entity.HasIndex(e => e.OrderId, "index_consolidation_bins_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('consolidation_bins_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BinNumber).HasColumnName("bin_number");
            entity.Property(e => e.Cancelled)
                .HasDefaultValue(0)
                .HasColumnName("cancelled");
            entity.Property(e => e.Consolidated)
                .HasDefaultValue(0)
                .HasColumnName("consolidated");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastItemUpdatedAt)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_item_updated_at");
            entity.Property(e => e.Location)
                .HasColumnType("character varying")
                .HasColumnName("location");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Pressed)
                .HasDefaultValue(0)
                .HasColumnName("pressed");
            entity.Property(e => e.Printed)
                .HasDefaultValue(0)
                .HasColumnName("printed");
            entity.Property(e => e.TotalItems)
                .HasDefaultValue(0)
                .HasColumnName("total_items");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.ConsolidationBins)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("fk_rails_839b7c3781");
        });

        modelBuilder.Entity<CvsAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cvs_addresses_pkey");

            entity.ToTable("cvs_addresses", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_cvs_addresses_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cvs_addresses_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("character varying")
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasColumnType("character varying")
                .HasColumnName("address2");
            entity.Property(e => e.Address3)
                .HasColumnType("character varying")
                .HasColumnName("address3");
            entity.Property(e => e.AddressType)
                .HasColumnType("character varying")
                .HasColumnName("address_type");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.ZipCode)
                .HasColumnType("character varying")
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<CvsAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cvs_assets_pkey");

            entity.ToTable("cvs_assets", "mww_ondemand_api");

            entity.HasIndex(e => e.ItemId, "index_cvs_assets_on_item_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cvs_assets_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FileName)
                .HasColumnType("character varying")
                .HasColumnName("file_name");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CvsItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cvs_items_pkey");

            entity.ToTable("cvs_items", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_cvs_items_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cvs_items_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderLineId).HasColumnName("order_line_id");
            entity.Property(e => e.Price)
                .HasColumnType("character varying")
                .HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .HasColumnType("character varying")
                .HasColumnName("product_code");
            entity.Property(e => e.ProductDescription)
                .HasColumnType("character varying")
                .HasColumnName("product_description");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CvsOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cvs_orders_pkey");

            entity.ToTable("cvs_orders", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('cvs_orders_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AddressId)
                .HasColumnType("character varying")
                .HasColumnName("address_id");
            entity.Property(e => e.ConsumerAddressId)
                .HasColumnType("character varying")
                .HasColumnName("consumer_address_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FileId)
                .HasColumnType("character varying")
                .HasColumnName("file_id");
            entity.Property(e => e.FulfillmentOptions)
                .HasColumnType("json")
                .HasColumnName("fulfillment_options");
            entity.Property(e => e.OutletId)
                .HasColumnType("character varying")
                .HasColumnName("outlet_id");
            entity.Property(e => e.PackingListPath)
                .HasColumnType("character varying")
                .HasColumnName("packing_list_path");
            entity.Property(e => e.ShipMethod)
                .HasColumnType("character varying")
                .HasColumnName("ship_method");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.StoreId)
                .HasColumnType("character varying")
                .HasColumnName("store_id");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorConsumerId)
                .HasColumnType("character varying")
                .HasColumnName("vendor_consumer_id");
            entity.Property(e => e.VendorId)
                .HasColumnType("character varying")
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorOrderId)
                .HasColumnType("character varying")
                .HasColumnName("vendor_order_id");
            entity.Property(e => e.VendorUnitId)
                .HasColumnType("character varying")
                .HasColumnName("vendor_unit_id");
        });

        modelBuilder.Entity<Design>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("designs_pkey");

            entity.ToTable("designs", "mww_ondemand_api");

            entity.HasIndex(e => e.LineItemId, "index_designs_on_line_item_id");

            entity.HasIndex(e => e.State, "index_designs_on_state");

            entity.HasIndex(e => e.UserId, "index_designs_on_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Detail)
                .HasColumnType("jsonb")
                .HasColumnName("detail");
            entity.Property(e => e.ImageContentType)
                .HasColumnType("character varying")
                .HasColumnName("image_content_type");
            entity.Property(e => e.ImageFileName)
                .HasColumnType("character varying")
                .HasColumnName("image_file_name");
            entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");
            entity.Property(e => e.ImageProcessing).HasColumnName("image_processing");
            entity.Property(e => e.ImageUpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("image_updated_at");
            entity.Property(e => e.LineItemId).HasColumnName("line_item_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LineItem).WithMany(p => p.Designs)
                .HasForeignKey(d => d.LineItemId)
                .HasConstraintName("fk_rails_11a03fa5b4");

            entity.HasOne(d => d.User).WithMany(p => p.Designs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_rails_7c71225162");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("images_pkey");

            entity.ToTable("images", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_images_on_order_id");

            entity.HasIndex(e => e.State, "index_images_on_state");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ImageContentType)
                .HasColumnType("character varying")
                .HasColumnName("image_content_type");
            entity.Property(e => e.ImageFileName)
                .HasColumnType("character varying")
                .HasColumnName("image_file_name");
            entity.Property(e => e.ImageFileSize).HasColumnName("image_file_size");
            entity.Property(e => e.ImageUpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("image_updated_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasColumnType("character varying")
                .HasColumnName("url");

            entity.HasOne(d => d.Order).WithMany(p => p.Images)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("fk_rails_a3c367843c");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("items_pkey");

            entity.ToTable("items", "mww_ondemand_api");

            entity.HasIndex(e => new { e.State, e.CreatedAt }, "InxStateSearchDate");

            entity.HasIndex(e => e.BatchNumber, "index_items_on_batch_number");

            entity.HasIndex(e => new { e.BatchNumber, e.CreatedAt }, "index_items_on_batch_number_and_created_at");

            entity.HasIndex(e => e.LineItemId, "index_items_on_line_item_id");

            entity.HasIndex(e => new { e.LineItemId, e.LegacyLineNumber }, "index_items_on_line_item_id_and_legacy_line_number").IsUnique();

            entity.HasIndex(e => e.State, "index_items_on_state");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.BatchNumber)
                .HasColumnType("character varying")
                .HasColumnName("batch_number");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LegacyLineNumber).HasColumnName("legacy_line_number");
            entity.Property(e => e.LineItemId).HasColumnName("line_item_id");
            entity.Property(e => e.OrderShipmentId).HasColumnName("order_shipment_id");
            entity.Property(e => e.PrintedOrder).HasColumnName("printed_order");
            entity.Property(e => e.PrunNumber)
                .HasColumnType("character varying")
                .HasColumnName("prun_number");
            entity.Property(e => e.Sla)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sla");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.LineItem).WithMany(p => p.Items)
                .HasForeignKey(d => d.LineItemId)
                .HasConstraintName("fk_rails_b0b85ec590");
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("line_items_pkey");

            entity.ToTable("line_items", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_line_items_on_order_id");

            entity.HasIndex(e => new { e.OrderId, e.LineNumber }, "index_line_items_on_order_id_and_line_number");

            entity.HasIndex(e => new { e.ProductCode, e.State }, "index_line_items_on_product_code_and_state");

            entity.HasIndex(e => e.State, "index_line_items_on_state");

            entity.HasIndex(e => e.Co, "line_items_by_co");

            entity.HasIndex(e => e.Po, "line_items_by_po_unique").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Co)
                .HasColumnType("character varying")
                .HasColumnName("co");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerLineNumber)
                .HasMaxLength(4)
                .HasColumnName("customer_line_number");
            entity.Property(e => e.CustomerProductCode)
                .HasMaxLength(75)
                .HasColumnName("customer_product_code");
            entity.Property(e => e.CustomerUpc)
                .HasColumnType("character varying")
                .HasColumnName("customer_upc");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.ItemProperties)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("item_properties");
            entity.Property(e => e.KitData)
                .HasDefaultValueSql("'[]'::json")
                .HasColumnType("jsonb")
                .HasColumnName("kit_data");
            entity.Property(e => e.LineNumber).HasColumnName("line_number");
            entity.Property(e => e.MoNumber)
                .HasColumnType("character varying")
                .HasColumnName("mo_number");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Po)
                .HasColumnType("character varying")
                .HasColumnName("po");
            entity.Property(e => e.ProductCode)
                .HasColumnType("character varying")
                .HasColumnName("product_code");
            entity.Property(e => e.ProductUpc)
                .HasMaxLength(30)
                .HasColumnName("product_upc");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.SpecificationId).HasColumnName("specification_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorItemPo)
                .HasColumnType("character varying")
                .HasColumnName("vendor_item_po");

            entity.HasOne(d => d.Order).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("line_items_order_id_fk");
        });

        modelBuilder.Entity<LineItemCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("line_item_counts", "mww_ondemand_api");

            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.Consolidated).HasColumnName("consolidated");
            entity.Property(e => e.Cut).HasColumnName("cut");
            entity.Property(e => e.Eton).HasColumnName("eton");
            entity.Property(e => e.Hold).HasColumnName("hold");
            entity.Property(e => e.LineItemId).HasColumnName("line_item_id");
            entity.Property(e => e.Loom).HasColumnName("loom");
            entity.Property(e => e.Packed).HasColumnName("packed");
            entity.Property(e => e.PillowBlow).HasColumnName("pillow_blow");
            entity.Property(e => e.Pressed).HasColumnName("pressed");
            entity.Property(e => e.Printed).HasColumnName("printed");
            entity.Property(e => e.QualityControl).HasColumnName("quality_control");
            entity.Property(e => e.Received).HasColumnName("received");
            entity.Property(e => e.Sewn).HasColumnName("sewn");
            entity.Property(e => e.Shipped).HasColumnName("shipped");
            entity.Property(e => e.Stretched).HasColumnName("stretched");
            entity.Property(e => e.Tentered).HasColumnName("tentered");
            entity.Property(e => e.Turned).HasColumnName("turned");
        });

        modelBuilder.Entity<LineItemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("line_item_views", "mww_ondemand_api");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerLineNumber)
                .HasMaxLength(4)
                .HasColumnName("customer_line_number");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemProperties)
                .HasColumnType("jsonb")
                .HasColumnName("item_properties");
            entity.Property(e => e.LineNumber).HasColumnName("line_number");
            entity.Property(e => e.Meta)
                .HasColumnType("json")
                .HasColumnName("meta");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Po)
                .HasColumnType("character varying")
                .HasColumnName("po");
            entity.Property(e => e.ProductUpc)
                .HasMaxLength(30)
                .HasColumnName("product_upc");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<LoggerDatum>(entity =>
        {
            entity.ToTable("LoggerData", "mww_ondemand_api");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders", "mww_ondemand_api");

            entity.HasIndex(e => e.CreatedAt, "index_orders_on_created_at");

            entity.HasIndex(e => e.State, "index_orders_on_state");

            entity.HasIndex(e => e.UserId, "index_orders_on_user_id");

            entity.HasIndex(e => e.VendorPo, "index_orders_on_vendor_po");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .HasColumnName("comments");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DistinctId)
                .HasColumnType("character varying")
                .HasColumnName("distinct_id");
            entity.Property(e => e.FutureShipDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("future_ship_date");
            entity.Property(e => e.LegacyShippingMethod)
                .HasColumnType("character varying")
                .HasColumnName("legacy_shipping_method");
            entity.Property(e => e.Location)
                .HasColumnType("character varying")
                .HasColumnName("location");
            entity.Property(e => e.PackingMessage).HasColumnName("packing_message");
            entity.Property(e => e.PostshipLabelUrl)
                .HasColumnType("character varying")
                .HasColumnName("postship_label_url");
            entity.Property(e => e.ShippingAccountNumber)
                .HasColumnType("character varying")
                .HasColumnName("shipping_account_number");
            entity.Property(e => e.ShippingDetails)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("shipping_details");
            entity.Property(e => e.ShippingMethod)
                .HasColumnType("character varying")
                .HasColumnName("shipping_method");
            entity.Property(e => e.Sla)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sla");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.TestOrder)
                .HasColumnType("character varying")
                .HasColumnName("test_order");
            entity.Property(e => e.UniqId)
                .HasPrecision(10, 2)
                .HasColumnName("uniq_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VendorPo)
                .HasMaxLength(50)
                .HasColumnName("vendor_po");
        });

        modelBuilder.Entity<OrderNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_notifications_pkey");

            entity.ToTable("order_notifications", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_order_notifications_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Event)
                .HasColumnType("character varying")
                .HasColumnName("event");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderNotifications)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_04928a2bdb");
        });

        modelBuilder.Entity<OrderShipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_shipments_pkey");

            entity.ToTable("order_shipments", "mww_ondemand_api");

            entity.HasIndex(e => new { e.ItemId, e.TrackingNumber }, "index_order_shipments_on_item_id_and_tracking_number").IsUnique();

            entity.HasIndex(e => e.TrackingNumber, "index_order_shipments_on_tracking_number");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.BoxId)
                .HasColumnType("character varying")
                .HasColumnName("box_id");
            entity.Property(e => e.BoxItemIds)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("box_item_ids");
            entity.Property(e => e.CarrierId)
                .HasColumnType("character varying")
                .HasColumnName("carrier_id");
            entity.Property(e => e.CarrierService)
                .HasColumnType("character varying")
                .HasColumnName("carrier_service");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.EstDeliveryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("est_delivery_date");
            entity.Property(e => e.Freight).HasColumnName("freight");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LabelFee)
                .HasPrecision(5, 2)
                .HasColumnName("label_fee");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PostageFee)
                .HasPrecision(7, 2)
                .HasColumnName("postage_fee");
            entity.Property(e => e.ShipmentNumber)
                .HasColumnType("character varying")
                .HasColumnName("shipment_number");
            entity.Property(e => e.ShippoObjectId)
                .HasColumnType("character varying")
                .HasColumnName("shippo_object_id");
            entity.Property(e => e.TrackingNumber)
                .HasColumnType("character varying")
                .HasColumnName("tracking_number");
            entity.Property(e => e.TrackingUrl)
                .HasColumnType("character varying")
                .HasColumnName("tracking_url");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Item).WithMany(p => p.OrderShipments)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("fk_rails_0e870dcdef");
        });

        modelBuilder.Entity<Printer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printers_pkey");

            entity.ToTable("printers", "mww_ondemand_api");

            entity.HasIndex(e => e.IpAddress, "index_printers_on_ip_address");

            entity.HasIndex(e => e.Name, "index_printers_on_name");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.HotFolderShare)
                .HasColumnType("character varying")
                .HasColumnName("hot_folder_share");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.IsReprintPrinter)
                .HasDefaultValue(false)
                .HasColumnName("is_reprint_printer");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PaperWidthInches).HasColumnName("paper_width_inches");
            entity.Property(e => e.PrinterDependencies)
                .HasColumnType("jsonb")
                .HasColumnName("printer_dependencies");
            entity.Property(e => e.PrinterExecutable)
                .HasColumnType("character varying")
                .HasColumnName("printer_executable");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PrintifyAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_addresses_pkey");

            entity.ToTable("printify_addresses", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_printify_addresses_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_addresses_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("character varying")
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasColumnType("character varying")
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasColumnType("character varying")
                .HasColumnName("company");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.Region)
                .HasColumnType("character varying")
                .HasColumnName("region");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Zip)
                .HasColumnType("character varying")
                .HasColumnName("zip");

            entity.HasOne(d => d.Order).WithMany(p => p.PrintifyAddresses)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_f673888e46");
        });

        modelBuilder.Entity<PrintifyEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_events_pkey");

            entity.ToTable("printify_events", "mww_ondemand_api");

            entity.HasIndex(e => e.AffectedItems, "index_printify_events_on_affected_items").HasMethod("gin");

            entity.HasIndex(e => e.OrderId, "index_printify_events_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_events_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("character varying")
                .HasColumnName("action");
            entity.Property(e => e.AffectedItems)
                .HasColumnType("character varying[]")
                .HasColumnName("affected_items");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Details)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("details");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.PrintifyEvents)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_52adbf75b3");
        });

        modelBuilder.Entity<PrintifyImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_images_pkey");

            entity.ToTable("printify_images", "mww_ondemand_api");

            entity.HasIndex(e => e.ItemId, "index_printify_images_on_item_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_images_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.PrintLocation)
                .HasColumnType("character varying")
                .HasColumnName("print_location");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasColumnType("character varying")
                .HasColumnName("url");

            entity.HasOne(d => d.Item).WithMany(p => p.PrintifyImages)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_70d9986c6b");
        });

        modelBuilder.Entity<PrintifyItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_items_pkey");

            entity.ToTable("printify_items", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_printify_items_on_order_id");

            entity.HasIndex(e => e.ProductId, "index_printify_items_on_product_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_items_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ItemProperties)
                .HasColumnType("jsonb")
                .HasColumnName("item_properties");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.UniqueId)
                .HasColumnType("character varying")
                .HasColumnName("unique_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.PrintifyItems)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_97bbbc7f97");

            entity.HasOne(d => d.Product).WithMany(p => p.PrintifyItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_56159cf5ee");
        });

        modelBuilder.Entity<PrintifyOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_orders_pkey");

            entity.ToTable("printify_orders", "mww_ondemand_api");

            entity.HasIndex(e => e.ShippingMethodId, "index_printify_orders_on_shipping_method_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_orders_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Reprint)
                .HasDefaultValue(false)
                .HasColumnName("reprint");
            entity.Property(e => e.Sample)
                .HasDefaultValue(false)
                .HasColumnName("sample");
            entity.Property(e => e.ShippingMethodId).HasColumnName("shipping_method_id");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.UniqueId)
                .HasColumnType("character varying")
                .HasColumnName("unique_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Xqc)
                .HasDefaultValue(false)
                .HasColumnName("xqc");

            entity.HasOne(d => d.ShippingMethod).WithMany(p => p.PrintifyOrders)
                .HasForeignKey(d => d.ShippingMethodId)
                .HasConstraintName("fk_rails_2c0f515256");
        });

        modelBuilder.Entity<PrintifyProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_products_pkey");

            entity.ToTable("printify_products", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_products_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BlankPrice)
                .HasDefaultValue(0)
                .HasColumnName("blank_price");
            entity.Property(e => e.CountryCode).HasColumnName("country_code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.MwwProductCode)
                .HasColumnType("character varying")
                .HasColumnName("mww_product_code");
            entity.Property(e => e.PrintingPrice)
                .HasDefaultValue(0)
                .HasColumnName("printing_price");
            entity.Property(e => e.ProcessingPrice)
                .HasDefaultValue(0)
                .HasColumnName("processing_price");
            entity.Property(e => e.Sku)
                .HasColumnType("character varying")
                .HasColumnName("sku");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PrintifyShippingMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("printify_shipping_methods_pkey");

            entity.ToTable("printify_shipping_methods", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('printify_shipping_methods_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Carrier)
                .HasColumnType("character varying")
                .HasColumnName("carrier");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Priority)
                .HasColumnType("character varying")
                .HasColumnName("priority");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products", "mww_ondemand_api");

            entity.HasIndex(e => e.ProductCode, "index_products_on_product_code");

            entity.HasIndex(e => e.Specifications, "index_products_on_specifications").HasMethod("gin");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasColumnType("character varying")
                .HasColumnName("category");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerItemReference)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("customer_item_reference");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.ProductCode)
                .HasColumnType("character varying")
                .HasColumnName("product_code");
            entity.Property(e => e.ProductType)
                .HasColumnType("character varying")
                .HasColumnName("product_type");
            entity.Property(e => e.Specifications)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("specifications");
            entity.Property(e => e.Upc)
                .HasMaxLength(30)
                .HasColumnName("upc");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ProductFlow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_flows_pkey");

            entity.ToTable("product_flows", "mww_ondemand_api");

            entity.HasIndex(e => e.FlowNumber, "index_product_flows_on_flow_number");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FlowNumber).HasColumnName("flow_number");
            entity.Property(e => e.FlowSequence)
                .HasColumnType("character varying")
                .HasColumnName("flow_sequence");
            entity.Property(e => e.Flows)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("flows");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<RedbubbleAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("redbubble_addresses_pkey");

            entity.ToTable("redbubble_addresses", "mww_ondemand_api");

            entity.HasIndex(e => e.RedbubbleOrderId, "index_redbubble_addresses_on_redbubble_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('redbubble_addresses_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.CountryCode)
                .HasColumnType("character varying")
                .HasColumnName("country_code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.Postcode)
                .HasColumnType("character varying")
                .HasColumnName("postcode");
            entity.Property(e => e.RedbubbleOrderId).HasColumnName("redbubble_order_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Street1)
                .HasColumnType("character varying")
                .HasColumnName("street1");
            entity.Property(e => e.Street2)
                .HasColumnType("character varying")
                .HasColumnName("street2");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.RedbubbleOrder).WithMany(p => p.RedbubbleAddresses)
                .HasForeignKey(d => d.RedbubbleOrderId)
                .HasConstraintName("fk_rails_d2bfc340b4");
        });

        modelBuilder.Entity<RedbubbleItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("redbubble_items_pkey");

            entity.ToTable("redbubble_items", "mww_ondemand_api");

            entity.HasIndex(e => e.RedbubbleOrderId, "index_redbubble_items_on_redbubble_order_id");

            entity.HasIndex(e => e.RedbubbleProductId, "index_redbubble_items_on_redbubble_product_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('redbubble_items_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BackImage)
                .HasColumnType("character varying")
                .HasColumnName("back_image");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FrontImage)
                .HasColumnType("character varying")
                .HasColumnName("front_image");
            entity.Property(e => e.ItemPo)
                .HasColumnType("character varying")
                .HasColumnName("item_po");
            entity.Property(e => e.PricingInformation)
                .HasColumnType("jsonb")
                .HasColumnName("pricing_information");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.RedbubbleOrderId).HasColumnName("redbubble_order_id");
            entity.Property(e => e.RedbubbleProductId).HasColumnName("redbubble_product_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.RedbubbleOrder).WithMany(p => p.RedbubbleItems)
                .HasForeignKey(d => d.RedbubbleOrderId)
                .HasConstraintName("fk_rails_e55d533b9d");

            entity.HasOne(d => d.RedbubbleProduct).WithMany(p => p.RedbubbleItems)
                .HasForeignKey(d => d.RedbubbleProductId)
                .HasConstraintName("fk_rails_34ddd1be7e");
        });

        modelBuilder.Entity<RedbubbleOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("redbubble_orders_pkey");

            entity.ToTable("redbubble_orders", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('redbubble_orders_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CallbackUrl)
                .HasColumnType("character varying")
                .HasColumnName("callback_url");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderType)
                .HasColumnType("character varying")
                .HasColumnName("order_type");
            entity.Property(e => e.ShippingMethod)
                .HasColumnType("character varying")
                .HasColumnName("shipping_method");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorPo)
                .HasColumnType("character varying")
                .HasColumnName("vendor_po");
        });

        modelBuilder.Entity<RedbubbleProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("redbubble_products_pkey");

            entity.ToTable("redbubble_products", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('redbubble_products_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BodyColor)
                .HasColumnType("character varying")
                .HasColumnName("body_color");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.MwwCode)
                .HasColumnType("character varying")
                .HasColumnName("mww_code");
            entity.Property(e => e.PrintLocation)
                .HasColumnType("character varying")
                .HasColumnName("print_location");
            entity.Property(e => e.Product)
                .HasColumnType("character varying")
                .HasColumnName("product");
            entity.Property(e => e.ProductType)
                .HasColumnType("character varying")
                .HasColumnName("product_type");
            entity.Property(e => e.Size)
                .HasColumnType("character varying")
                .HasColumnName("size");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reports_pkey");

            entity.ToTable("reports", "mww_ondemand_api");

            entity.HasIndex(e => e.Key, "index_reports_on_key");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NumberDaysToKeep).HasColumnName("number_days_to_keep");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<SchemaMigration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("schema_migrations", "mww_ondemand_api");

            entity.HasIndex(e => e.Version, "unique_schema_migrations").IsUnique();

            entity.Property(e => e.Version)
                .HasColumnType("character varying")
                .HasColumnName("version");
        });

        modelBuilder.Entity<SeriLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SeriLog_pkey");

            entity.ToTable("SeriLog", "mww_ondemand_api");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"SeriLog_Id_seq\"'::regclass)");
            entity.Property(e => e.LogEvent).HasColumnType("jsonb");
        });

        modelBuilder.Entity<ShipType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ship_types_pkey");

            entity.ToTable("ship_types", "mww_ondemand_api");

            entity.HasIndex(e => e.Provider, "index_ship_types_on_provider");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Detail)
                .HasColumnType("jsonb")
                .HasColumnName("detail");
            entity.Property(e => e.Provider)
                .HasColumnType("character varying")
                .HasColumnName("provider");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShowLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("show_labels_pkey");

            entity.ToTable("show_labels", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('show_labels_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.PriceA)
                .HasColumnType("character varying")
                .HasColumnName("price_a");
            entity.Property(e => e.Style)
                .HasColumnType("character varying")
                .HasColumnName("style");
            entity.Property(e => e.StyleDesc)
                .HasColumnType("character varying")
                .HasColumnName("style_desc");
            entity.Property(e => e.StyleUdf02).HasColumnName("style_udf_02");
            entity.Property(e => e.Unit)
                .HasColumnType("character varying")
                .HasColumnName("unit");
            entity.Property(e => e.Upc)
                .HasColumnType("character varying")
                .HasColumnName("upc");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringArtwork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_artworks_pkey");

            entity.ToTable("teespring_artworks", "mww_ondemand_api");

            entity.HasIndex(e => e.FulfillmentJobId, "index_teespring_artworks_on_fulfillment_job_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_artworks_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Eps)
                .HasColumnType("character varying")
                .HasColumnName("eps");
            entity.Property(e => e.FulfillmentJobId).HasColumnName("fulfillment_job_id");
            entity.Property(e => e.Inks)
                .HasDefaultValueSql("'{}'::character varying[]")
                .HasColumnType("character varying[]")
                .HasColumnName("inks");
            entity.Property(e => e.Pdf)
                .HasColumnType("character varying")
                .HasColumnName("pdf");
            entity.Property(e => e.Png)
                .HasColumnType("character varying")
                .HasColumnName("png");
            entity.Property(e => e.Token)
                .HasColumnType("character varying")
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringFulfillmentJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_fulfillment_jobs_pkey");

            entity.ToTable("teespring_fulfillment_jobs", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_fulfillment_jobs_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ActiveRecordConnectionAdaptersPostgreSqlTableDefinition)
                .HasColumnType("character varying")
                .HasColumnName("#<ActiveRecord::ConnectionAdapters::PostgreSQL::TableDefinition");
            entity.Property(e => e.ArtworkReady).HasColumnName("artwork_ready");
            entity.Property(e => e.Attachments)
                .HasDefaultValueSql("'{}'::character varying[]")
                .HasColumnType("character varying[]")
                .HasColumnName("attachments");
            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.CloseDate)
                .HasColumnType("character varying")
                .HasColumnName("close_date");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.JobId)
                .HasColumnType("character varying")
                .HasColumnName("job_id");
            entity.Property(e => e.Notes)
                .HasDefaultValueSql("'{}'::character varying[]")
                .HasColumnType("character varying[]")
                .HasColumnName("notes");
            entity.Property(e => e.Procedure)
                .HasColumnType("character varying")
                .HasColumnName("procedure");
            entity.Property(e => e.ProductionType)
                .HasColumnType("character varying")
                .HasColumnName("production_type");
            entity.Property(e => e.ReprintOfId)
                .HasColumnType("character varying")
                .HasColumnName("reprint_of_id");
            entity.Property(e => e.ReprintReason)
                .HasColumnType("character varying")
                .HasColumnName("reprint_reason");
            entity.Property(e => e.SlaDueDate)
                .HasColumnType("character varying")
                .HasColumnName("sla_due_date");
            entity.Property(e => e.SpecialHandling)
                .HasDefaultValueSql("'{}'::character varying[]")
                .HasColumnType("character varying[]")
                .HasColumnName("special_handling");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringInk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_inks_pkey");

            entity.ToTable("teespring_inks", "mww_ondemand_api");

            entity.HasIndex(e => e.FulfillmentJobId, "index_teespring_inks_on_fulfillment_job_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_inks_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentJobId).HasColumnName("fulfillment_job_id");
            entity.Property(e => e.FullName)
                .HasColumnType("character varying")
                .HasColumnName("full_name");
            entity.Property(e => e.Hex)
                .HasColumnType("character varying")
                .HasColumnName("hex");
            entity.Property(e => e.Token)
                .HasColumnType("character varying")
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringInventoryDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_inventory_details_pkey");

            entity.ToTable("teespring_inventory_details", "mww_ondemand_api");

            entity.HasIndex(e => e.FulfillmentJobId, "index_teespring_inventory_details_on_fulfillment_job_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_inventory_details_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.FulfillmentJobId).HasColumnName("fulfillment_job_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Sku)
                .HasColumnType("character varying")
                .HasColumnName("sku");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringInventoryItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_inventory_items_pkey");

            entity.ToTable("teespring_inventory_items", "mww_ondemand_api");

            entity.HasIndex(e => e.ShipmentId, "index_teespring_inventory_items_on_shipment_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_inventory_items_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");
            entity.Property(e => e.Sku)
                .HasColumnType("character varying")
                .HasColumnName("sku");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringLayout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_layouts_pkey");

            entity.ToTable("teespring_layouts", "mww_ondemand_api");

            entity.HasIndex(e => e.InventoryDetailId, "index_teespring_layouts_on_inventory_detail_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_layouts_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ArtworkToken)
                .HasColumnType("character varying")
                .HasColumnName("artwork_token");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.InventoryDetailId).HasColumnName("inventory_detail_id");
            entity.Property(e => e.Location)
                .HasColumnType("character varying")
                .HasColumnName("location");
            entity.Property(e => e.MockupToken)
                .HasColumnType("character varying")
                .HasColumnName("mockup_token");
            entity.Property(e => e.PlacementToken)
                .HasColumnType("character varying")
                .HasColumnName("placement_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringMockup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_mockups_pkey");

            entity.ToTable("teespring_mockups", "mww_ondemand_api");

            entity.HasIndex(e => e.FulfillmentJobId, "index_teespring_mockups_on_fulfillment_job_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_mockups_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentJobId).HasColumnName("fulfillment_job_id");
            entity.Property(e => e.Token)
                .HasColumnType("character varying")
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasColumnType("character varying")
                .HasColumnName("url");
        });

        modelBuilder.Entity<TeespringPlacement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_placements_pkey");

            entity.ToTable("teespring_placements", "mww_ondemand_api");

            entity.HasIndex(e => e.FulfillmentJobId, "index_teespring_placements_on_fulfillment_job_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_placements_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AlignmentType)
                .HasColumnType("character varying")
                .HasColumnName("alignment_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentJobId).HasColumnName("fulfillment_job_id");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Token)
                .HasColumnType("character varying")
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.XOffset).HasColumnName("x_offset");
            entity.Property(e => e.YOffset).HasColumnName("y_offset");
        });

        modelBuilder.Entity<TeespringRecipient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_recipients_pkey");

            entity.ToTable("teespring_recipients", "mww_ondemand_api");

            entity.HasIndex(e => e.ShipmentId, "index_teespring_recipients_on_shipment_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_recipients_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AddressLine1)
                .HasColumnType("character varying")
                .HasColumnName("address_line1");
            entity.Property(e => e.AddressLine2)
                .HasColumnType("character varying")
                .HasColumnName("address_line2");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CountryCode)
                .HasColumnType("character varying")
                .HasColumnName("country_code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.EmailAddress)
                .HasColumnType("character varying")
                .HasColumnName("email_address");
            entity.Property(e => e.FullName)
                .HasColumnType("character varying")
                .HasColumnName("full_name");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.Province)
                .HasColumnType("character varying")
                .HasColumnName("province");
            entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringShipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_shipments_pkey");

            entity.ToTable("teespring_shipments", "mww_ondemand_api");

            entity.HasIndex(e => e.FulfillmentJobId, "index_teespring_shipments_on_fulfillment_job_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_shipments_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FulfillmentJobId).HasColumnName("fulfillment_job_id");
            entity.Property(e => e.ShipperReference)
                .HasColumnType("character varying")
                .HasColumnName("shipper_reference");
            entity.Property(e => e.ShippingWeight).HasColumnName("shipping_weight");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TeespringShippingLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teespring_shipping_labels_pkey");

            entity.ToTable("teespring_shipping_labels", "mww_ondemand_api");

            entity.HasIndex(e => e.ShipmentId, "index_teespring_shipping_labels_on_shipment_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teespring_shipping_labels_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Carrier)
                .HasColumnType("character varying")
                .HasColumnName("carrier");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LabelErrors)
                .HasColumnType("character varying")
                .HasColumnName("label_errors");
            entity.Property(e => e.LabelZpl)
                .HasColumnType("character varying")
                .HasColumnName("label_zpl");
            entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");
            entity.Property(e => e.ShipperReference)
                .HasColumnType("character varying")
                .HasColumnName("shipper_reference");
            entity.Property(e => e.TrackingNumber)
                .HasColumnType("character varying")
                .HasColumnName("tracking_number");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users", "mww_ondemand_api");

            entity.HasIndex(e => new { e.ApiKey, e.Provider }, "index_users_on_api_key_and_provider");

            entity.HasIndex(e => e.AuthenticationToken, "index_users_on_authentication_token");

            entity.HasIndex(e => e.ConfirmationToken, "index_users_on_confirmation_token").IsUnique();

            entity.HasIndex(e => new { e.DeletedAt, e.AuthenticationToken, e.Id }, "index_users_on_deleted_at_and_authentication_token_and_id");

            entity.HasIndex(e => e.Email, "index_users_on_email").IsUnique();

            entity.HasIndex(e => new { e.Id, e.AuthenticationToken }, "index_users_on_id_and_authentication_token");

            entity.HasIndex(e => e.ResetPasswordToken, "index_users_on_reset_password_token").IsUnique();

            entity.HasIndex(e => new { e.Uid, e.Provider }, "index_users_on_uid_and_provider").IsUnique();

            entity.HasIndex(e => e.UnlockToken, "index_users_on_unlock_token").IsUnique();

            entity.HasIndex(e => e.VendorName, "index_users_on_vendor_name");

            entity.HasIndex(e => e.Tags, "users_tags_idx").HasMethod("gin");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasColumnType("character varying")
                .HasColumnName("address");
            entity.Property(e => e.AddressValidation)
                .HasDefaultValue(true)
                .HasColumnName("address_validation");
            entity.Property(e => e.ApiKey)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("api_key");
            entity.Property(e => e.AuthenticationToken)
                .HasColumnType("character varying")
                .HasColumnName("authentication_token");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.ConfirmationSentAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("confirmation_sent_at");
            entity.Property(e => e.ConfirmationToken)
                .HasColumnType("character varying")
                .HasColumnName("confirmation_token");
            entity.Property(e => e.ConfirmedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("confirmed_at");
            entity.Property(e => e.ContactPhone)
                .HasColumnType("character varying")
                .HasColumnName("contact_phone");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrentSignInAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("current_sign_in_at");
            entity.Property(e => e.CurrentSignInIp)
                .HasColumnType("character varying")
                .HasColumnName("current_sign_in_ip");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.EmailOptIn)
                .HasDefaultValue(false)
                .HasColumnName("email_opt_in");
            entity.Property(e => e.EncryptedPassword)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("encrypted_password");
            entity.Property(e => e.FailedAttempts)
                .HasDefaultValue(0)
                .HasColumnName("failed_attempts");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.LastActiveAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_active_at");
            entity.Property(e => e.LastSignInAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_sign_in_at");
            entity.Property(e => e.LastSignInIp)
                .HasColumnType("character varying")
                .HasColumnName("last_sign_in_ip");
            entity.Property(e => e.LegacyPassword)
                .HasColumnType("character varying")
                .HasColumnName("legacy_password");
            entity.Property(e => e.LegacyVendorId)
                .HasColumnType("character varying")
                .HasColumnName("legacy_vendor_id");
            entity.Property(e => e.LockedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("locked_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Nickname)
                .HasColumnType("character varying")
                .HasColumnName("nickname");
            entity.Property(e => e.OnCreditHold)
                .HasDefaultValue(false)
                .HasColumnName("on_credit_hold");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.Preferences)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("preferences");
            entity.Property(e => e.Provider)
                .HasDefaultValueSql("'email'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("provider");
            entity.Property(e => e.RememberCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("remember_created_at");
            entity.Property(e => e.ResetPasswordSentAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("reset_password_sent_at");
            entity.Property(e => e.ResetPasswordToken)
                .HasColumnType("character varying")
                .HasColumnName("reset_password_token");
            entity.Property(e => e.ShopFloorId)
                .HasColumnType("character varying")
                .HasColumnName("shop_floor_id");
            entity.Property(e => e.SignInCount)
                .HasDefaultValue(0)
                .HasColumnName("sign_in_count");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Tags)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("tags");
            entity.Property(e => e.Uid)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("uid");
            entity.Property(e => e.UnconfirmedEmail)
                .HasColumnType("character varying")
                .HasColumnName("unconfirmed_email");
            entity.Property(e => e.UnlockToken)
                .HasColumnType("character varying")
                .HasColumnName("unlock_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserPhone)
                .HasColumnType("character varying")
                .HasColumnName("user_phone");
            entity.Property(e => e.VendorName)
                .HasMaxLength(100)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("versions_pkey");

            entity
                .ToTable("versions", "mww_ondemand_api")
                .HasAnnotation("Npgsql:StorageParameter:autovacuum_analyze_scale_factor", "0.0")
                .HasAnnotation("Npgsql:StorageParameter:autovacuum_analyze_threshold", "5000")
                .HasAnnotation("Npgsql:StorageParameter:autovacuum_vacuum_scale_factor", "0.0")
                .HasAnnotation("Npgsql:StorageParameter:autovacuum_vacuum_threshold", "5000");

            entity.HasIndex(e => new { e.ItemType, e.ItemId }, "index_versions_on_item_type_and_item_id");

            entity.HasIndex(e => e.TransactionId, "index_versions_on_transaction_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Event)
                .HasColumnType("character varying")
                .HasColumnName("event");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemType)
                .HasColumnType("character varying")
                .HasColumnName("item_type");
            entity.Property(e => e.Object).HasColumnName("object");
            entity.Property(e => e.ObjectChanges)
                .HasColumnType("character varying")
                .HasColumnName("object_changes");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.Whodunnit)
                .HasColumnType("character varying")
                .HasColumnName("whodunnit");
        });

        modelBuilder.Entity<VersionAssociation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("version_associations_pkey");

            entity.ToTable("version_associations", "mww_ondemand_api");

            entity.HasIndex(e => new { e.ForeignKeyName, e.ForeignKeyId }, "index_version_associations_on_foreign_key");

            entity.HasIndex(e => e.VersionId, "index_version_associations_on_version_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.ForeignKeyId).HasColumnName("foreign_key_id");
            entity.Property(e => e.ForeignKeyName)
                .HasColumnType("character varying")
                .HasColumnName("foreign_key_name");
            entity.Property(e => e.VersionId).HasColumnName("version_id");
        });

        modelBuilder.Entity<WalmartAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("walmart_addresses_pkey");

            entity.ToTable("walmart_addresses", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_walmart_addresses_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('walmart_addresses_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("character varying")
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasColumnType("character varying")
                .HasColumnName("address2");
            entity.Property(e => e.AddressType)
                .HasColumnType("character varying")
                .HasColumnName("address_type");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WalmartCharge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("walmart_charges_pkey");

            entity.ToTable("walmart_charges", "mww_ondemand_api");

            entity.HasIndex(e => e.ItemId, "index_walmart_charges_on_item_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('walmart_charges_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("amount");
            entity.Property(e => e.ChargeName)
                .HasColumnType("character varying")
                .HasColumnName("charge_name");
            entity.Property(e => e.ChargeType)
                .HasColumnType("character varying")
                .HasColumnName("charge_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Tax)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("tax");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WalmartFulfillment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("walmart_fulfillments_pkey");

            entity.ToTable("walmart_fulfillments", "mww_ondemand_api");

            entity.HasIndex(e => e.ItemId, "index_walmart_fulfillments_on_item_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('walmart_fulfillments_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Delivery)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("delivery");
            entity.Property(e => e.FulfillmentOption)
                .HasColumnType("character varying")
                .HasColumnName("fulfillment_option");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.OfferId)
                .HasColumnType("character varying")
                .HasColumnName("offer_id");
            entity.Property(e => e.OriginalCarrierMethod)
                .HasColumnType("character varying")
                .HasColumnName("original_carrier_method");
            entity.Property(e => e.PickUpBy)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("pick_up_by");
            entity.Property(e => e.PickUpDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("pick_up_date");
            entity.Property(e => e.ShipMethod)
                .HasColumnType("character varying")
                .HasColumnName("ship_method");
            entity.Property(e => e.StoreId)
                .HasColumnType("character varying")
                .HasColumnName("store_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WalmartItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("walmart_items_pkey");

            entity.ToTable("walmart_items", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_walmart_items_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('walmart_items_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Contents)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("contents");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.LineNumber).HasColumnName("line_number");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductName)
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ReferenceLineId)
                .HasColumnType("character varying")
                .HasColumnName("reference_line_id");
            entity.Property(e => e.Sku)
                .HasColumnType("character varying")
                .HasColumnName("sku");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weight)
                .HasPrecision(10, 3)
                .HasColumnName("weight");
            entity.Property(e => e.WeightUnit)
                .HasColumnType("character varying")
                .HasColumnName("weight_unit");
        });

        modelBuilder.Entity<WalmartOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("walmart_orders_pkey");

            entity.ToTable("walmart_orders", "mww_ondemand_api");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('walmart_orders_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BuyerId)
                .HasColumnType("character varying")
                .HasColumnName("buyer_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerEmailId)
                .HasColumnType("character varying")
                .HasColumnName("customer_email_id");
            entity.Property(e => e.CustomerOrderId)
                .HasColumnType("character varying")
                .HasColumnName("customer_order_id");
            entity.Property(e => e.Details)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("details");
            entity.Property(e => e.EstimatedDelieveryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("estimated_delievery_date");
            entity.Property(e => e.EstimatedShipDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("estimated_ship_date");
            entity.Property(e => e.IsGuest).HasColumnName("is_guest");
            entity.Property(e => e.Mart)
                .HasColumnType("character varying")
                .HasColumnName("mart");
            entity.Property(e => e.OrderDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("order_date");
            entity.Property(e => e.PaymentTypes)
                .HasDefaultValueSql("'{}'::character varying[]")
                .HasColumnType("character varying[]")
                .HasColumnName("payment_types");
            entity.Property(e => e.PurchaseOrderId)
                .HasColumnType("character varying")
                .HasColumnName("purchase_order_id");
            entity.Property(e => e.ShipMethod)
                .HasColumnType("character varying")
                .HasColumnName("ship_method");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WalmartPickupPerson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("walmart_pickup_people_pkey");

            entity.ToTable("walmart_pickup_people", "mww_ondemand_api");

            entity.HasIndex(e => e.OrderId, "index_walmart_pickup_people_on_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('walmart_pickup_people_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Webhook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("webhooks_pkey");

            entity.ToTable("webhooks", "mww_ondemand_api");

            entity.HasIndex(e => e.UserId, "index_webhooks_on_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("next_id()")
                .HasColumnName("id");
            entity.Property(e => e.Authorization)
                .HasColumnType("character varying")
                .HasColumnName("authorization");
            entity.Property(e => e.AuthorizationType)
                .HasColumnType("character varying")
                .HasColumnName("authorization_type");
            entity.Property(e => e.Cancelled)
                .HasDefaultValue(false)
                .HasColumnName("cancelled");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Cut)
                .HasDefaultValue(false)
                .HasColumnName("cut");
            entity.Property(e => e.DesignDownloaded)
                .HasDefaultValue(false)
                .HasColumnName("design_downloaded");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(false)
                .HasColumnName("enabled");
            entity.Property(e => e.NotValid)
                .HasDefaultValue(false)
                .HasColumnName("not_valid");
            entity.Property(e => e.Packed)
                .HasDefaultValue(false)
                .HasColumnName("packed");
            entity.Property(e => e.Pressed)
                .HasDefaultValue(false)
                .HasColumnName("pressed");
            entity.Property(e => e.Printed)
                .HasDefaultValue(false)
                .HasColumnName("printed");
            entity.Property(e => e.Processed)
                .HasDefaultValue(false)
                .HasColumnName("processed");
            entity.Property(e => e.Received)
                .HasDefaultValue(false)
                .HasColumnName("received");
            entity.Property(e => e.Sewn)
                .HasDefaultValue(false)
                .HasColumnName("sewn");
            entity.Property(e => e.Shipped)
                .HasDefaultValue(false)
                .HasColumnName("shipped");
            entity.Property(e => e.Turned)
                .HasDefaultValue(false)
                .HasColumnName("turned");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasColumnType("character varying")
                .HasColumnName("url");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Webhooks)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_51bf96d3bc");
        });
        modelBuilder.HasSequence("products_id_seq", "mww_ondemand_api");
        modelBuilder.HasSequence("table_id_seq", "mww_ondemand_api");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
