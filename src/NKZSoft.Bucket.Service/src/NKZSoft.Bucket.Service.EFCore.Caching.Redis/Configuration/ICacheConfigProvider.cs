namespace NKZSoft.Bucket.Service.EFCore.Caching.Redis.Configuration;

internal interface ICacheConfigProvider
{
    CacheConfigurationSection GetConfig();
}
