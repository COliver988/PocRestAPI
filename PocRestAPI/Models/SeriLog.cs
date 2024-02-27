using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class SeriLog
{
    public int Id { get; set; }

    public int? Level { get; set; }

    public string? TestColumnName { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? LogEvent { get; set; }
}
