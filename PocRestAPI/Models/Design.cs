using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Design
{
    public long Id { get; set; }

    public string? Detail { get; set; }

    public long? UserId { get; set; }

    public long? LineItemId { get; set; }

    public bool? ImageProcessing { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ImageFileName { get; set; }

    public string? ImageContentType { get; set; }

    public int? ImageFileSize { get; set; }

    public DateTime? ImageUpdatedAt { get; set; }

    public string? State { get; set; }

    public virtual LineItem? LineItem { get; set; }

    public virtual User? User { get; set; }
}
