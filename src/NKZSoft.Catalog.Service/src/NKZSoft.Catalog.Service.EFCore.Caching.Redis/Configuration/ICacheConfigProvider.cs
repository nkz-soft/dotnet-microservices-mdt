namespace NKZSoft.Catalog.Service.EFCore.Caching.Redis.Configuration;

internal interface ICacheConfigProvider
{
    CacheConfigurationSection GetConfig();
}
