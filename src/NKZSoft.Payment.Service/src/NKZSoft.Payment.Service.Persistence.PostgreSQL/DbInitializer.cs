﻿namespace NKZSoft.Payment.Service.Persistence.PostgreSQL;

public class DbInitializer : IDbInitializer
{
    public Task SeedAsync(IApplicationDbContext context, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
