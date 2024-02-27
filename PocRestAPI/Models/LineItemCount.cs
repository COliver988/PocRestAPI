using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class LineItemCount
{
    public long? LineItemId { get; set; }

    public long? Received { get; set; }

    public long? Cancelled { get; set; }

    public long? Loom { get; set; }

    public long? Printed { get; set; }

    public long? Hold { get; set; }

    public long? Stretched { get; set; }

    public long? Pressed { get; set; }

    public long? Cut { get; set; }

    public long? Consolidated { get; set; }

    public long? Eton { get; set; }

    public long? Packed { get; set; }

    public long? PillowBlow { get; set; }

    public long? Tentered { get; set; }

    public long? QualityControl { get; set; }

    public long? Sewn { get; set; }

    public long? Turned { get; set; }

    public long? Shipped { get; set; }
}
