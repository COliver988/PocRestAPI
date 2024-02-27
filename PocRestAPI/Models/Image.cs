using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Image
{
    public long Id { get; set; }

    public string Url { get; set; } = null!;

    public long? OrderId { get; set; }

    public string? Type { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ImageFileName { get; set; }

    public string? ImageContentType { get; set; }

    public int? ImageFileSize { get; set; }

    public DateTime? ImageUpdatedAt { get; set; }

    public string? State { get; set; }

    public virtual Order? Order { get; set; }
}
