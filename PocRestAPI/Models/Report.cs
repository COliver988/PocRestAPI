using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class Report
{
    public long Id { get; set; }

    public string? Key { get; set; }

    public string? Name { get; set; }

    public int? NumberDaysToKeep { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
