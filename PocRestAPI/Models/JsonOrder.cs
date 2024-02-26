using Newtonsoft.Json;

namespace PocRestAPI.Models
{
    public record JsonOrder
    {
        // Root myDeserializedrecord = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public record Attributes
        {
            [JsonProperty("vendor-po")]
            public string VendorPo { get; set; }

            [JsonProperty("shipping-method")]
            public string ShippingMethod { get; set; }

            [JsonProperty("shipping-account-number")]
            public string ShippingAccountNumber { get; set; }

            [JsonProperty("test-order")]
            public string TestOrder { get; set; }

            [JsonProperty("shipping-details")]
            public ShippingDetails ShippingDetails { get; set; }
        }

        public record Root
        {
            public string Type { get; set; }
            public Attributes Attributes { get; set; }
        }

        public record ShippingDetails
        {
            public string IOSS { get; set; }
            public string TrackingUrl { get; set; }
            public string TrackingNumber { get; set; }
        }


    }
}
