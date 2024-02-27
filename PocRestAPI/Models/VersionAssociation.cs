using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class VersionAssociation
{
    public long Id { get; set; }

    public long? VersionId { get; set; }

    public string ForeignKeyName { get; set; } = null!;

    public long? ForeignKeyId { get; set; }
}
