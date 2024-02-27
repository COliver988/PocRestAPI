using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class CimpressMcpContact
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public int? PreparedOrderId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
