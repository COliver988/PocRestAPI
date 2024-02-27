using System;
using System.Collections.Generic;
using System.Net;

namespace PocRestAPI.Models;

public partial class Printer
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? HotFolderShare { get; set; }

    public int? PaperWidthInches { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? PrinterExecutable { get; set; }

    public IPAddress? IpAddress { get; set; }

    public string? PrinterDependencies { get; set; }

    public bool? IsReprintPrinter { get; set; }
}
