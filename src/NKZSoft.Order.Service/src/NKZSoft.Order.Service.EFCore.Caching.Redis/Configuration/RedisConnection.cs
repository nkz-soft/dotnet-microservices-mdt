namespace NKZSoft.Order.Service.EFCore.Caching.Redis.Configuration;

internal sealed record RedisConnection
{
    [DisallowNull]
    public string? ConnectionString { get; init; }

    public bool HealthCheckEnabled { get; set; }
}
