﻿namespace MyApplication.Models;

public sealed class InstallationConfiguration : ConfigurationBase
{
    public long InstallationId { get; set; }

    public long OwnerId { get; set; }
}
