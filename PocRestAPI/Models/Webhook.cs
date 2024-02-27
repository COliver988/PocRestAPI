using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Webhook
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string? Url { get; set; }

    public bool? Enabled { get; set; }

    public bool? Received { get; set; }

    public bool? DesignDownloaded { get; set; }

    public bool? NotValid { get; set; }

    public bool? Processed { get; set; }

    public bool? Shipped { get; set; }

    public bool? Cancelled { get; set; }

    public bool? Printed { get; set; }

    public bool? Pressed { get; set; }

    public bool? Cut { get; set; }

    public bool? Sewn { get; set; }

    public bool? Turned { get; set; }

    public bool? Packed { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Authorization { get; set; }

    public string? AuthorizationType { get; set; }

    public virtual User User { get; set; } = null!;
}
