namespace NKZSoft.Bucket.Service.Application.Common.Interfaces;

public interface IDbInitializer
{
    Task SeedAsync(IApplicationDbContext context, CancellationToken cancellationToken = default);
}
