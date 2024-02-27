using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class TeespringFulfillmentJob
{
    public int Id { get; set; }

    public string? JobId { get; set; }

    public string? ProductionType { get; set; }

    public List<string>? SpecialHandling { get; set; }

    public string? Procedure { get; set; }

    public string? SlaDueDate { get; set; }

    public bool? Closed { get; set; }

    public bool? ArtworkReady { get; set; }

    public bool? Cancelled { get; set; }

    public List<string>? Attachments { get; set; }

    public string? CloseDate { get; set; }

    public List<string>? Notes { get; set; }

    public string? ReprintOfId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? ReprintReason { get; set; }

    public string? ActiveRecordConnectionAdaptersPostgreSqlTableDefinition { get; set; }
}
