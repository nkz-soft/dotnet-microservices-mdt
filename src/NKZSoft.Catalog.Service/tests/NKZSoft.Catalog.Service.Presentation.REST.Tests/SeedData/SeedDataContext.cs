namespace NKZSoft.Catalog.Service.Presentation.REST.Tests.SeedData;

internal sealed partial class SeedDataContext : IDbInitializer
{
    public async Task SeedAsync(IApplicationDbContext context, CancellationToken cancellationToken = default)
    {
        await context.AppDbContext.Set<Product>().AddRangeAsync(Products, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
