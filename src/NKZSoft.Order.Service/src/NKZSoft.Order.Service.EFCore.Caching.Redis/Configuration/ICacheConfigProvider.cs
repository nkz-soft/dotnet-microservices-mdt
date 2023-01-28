namespace NKZSoft.Order.Service.EFCore.Caching.Redis.Configuration;

internal interface ICacheConfigProvider
{
    CacheConfigurationSection GetConfig();
}
