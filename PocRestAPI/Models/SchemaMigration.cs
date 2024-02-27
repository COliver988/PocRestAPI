using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class SchemaMigration
{
    public string Version { get; set; } = null!;
}
