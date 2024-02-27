using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CvsAsset
{
    public long Id { get; set; }

    public string? FileName { get; set; }

    public long? ItemId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
