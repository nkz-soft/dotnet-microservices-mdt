namespace NKZSoft.Payment.Service.EFCore.Caching.Redis.Configuration;

internal interface ICacheConfigProvider
{
    CacheConfigurationSection GetConfig();
}
