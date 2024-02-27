using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class OrderNotification
{
    public long Id { get; set; }

    public string? Event { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime Timestamp { get; set; }

    public long OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;
}
