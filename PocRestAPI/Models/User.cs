using System;
using System.Collections.Generic;

namespace PocRestAPI.Models;

public partial class User
{
    public long Id { get; set; }

    public string Provider { get; set; } = null!;

    public string Uid { get; set; } = null!;

    public string ApiKey { get; set; } = null!;

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string EncryptedPassword { get; set; } = null!;

    public string? ResetPasswordToken { get; set; }

    public DateTime? ResetPasswordSentAt { get; set; }

    public DateTime? RememberCreatedAt { get; set; }

    public int SignInCount { get; set; }

    public DateTime? CurrentSignInAt { get; set; }

    public DateTime? LastSignInAt { get; set; }

    public string? CurrentSignInIp { get; set; }

    public string? LastSignInIp { get; set; }

    public string? ConfirmationToken { get; set; }

    public DateTime? ConfirmedAt { get; set; }

    public DateTime? ConfirmationSentAt { get; set; }

    public string? UnconfirmedEmail { get; set; }

    public int FailedAttempts { get; set; }

    public string? UnlockToken { get; set; }

    public DateTime? LockedAt { get; set; }

    public string? Nickname { get; set; }

    public string? Image { get; set; }

    public string? AuthenticationToken { get; set; }

    public string Tags { get; set; } = null!;

    public DateTime? DeletedAt { get; set; }

    public string? LegacyVendorId { get; set; }

    public string? VendorName { get; set; }

    public bool OnCreditHold { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? LegacyPassword { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? UserPhone { get; set; }

    public string? ContactPhone { get; set; }

    public bool? EmailOptIn { get; set; }

    public string? Preferences { get; set; }

    public DateTime? LastActiveAt { get; set; }

    public string? ShopFloorId { get; set; }

    public bool? AddressValidation { get; set; }

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();

    public virtual ICollection<Webhook> Webhooks { get; set; } = new List<Webhook>();
}
