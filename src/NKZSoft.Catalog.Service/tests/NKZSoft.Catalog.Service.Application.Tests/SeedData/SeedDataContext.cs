using NKZSoft.Catalog.Service.Persistence.PostgreSQL;

namespace NKZSoft.Catalog.Service.Application.Tests.SeedData;

using Application.Common.Interfaces;
using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

public sealed partial class SeedDataContext : IDbInitializer
{
    public async Task SeedAsync(IApplicationDbContext context, CancellationToken cancellationToken)
    {
        await context.AppDbContext.Set<Product>().AddRangeAsync(Products, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
