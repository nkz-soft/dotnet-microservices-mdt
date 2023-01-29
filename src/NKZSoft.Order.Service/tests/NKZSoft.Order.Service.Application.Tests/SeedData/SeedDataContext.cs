using NKZSoft.Order.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
using NKZSoft.Order.Service.Persistence.PostgreSQL;

namespace NKZSoft.Order.Service.Application.Tests.SeedData;

using Application.Common.Interfaces;

public sealed partial class SeedDataContext : IDbInitializer
{
    public async Task SeedAsync(IApplicationDbContext context, CancellationToken cancellationToken)
    {
        await context.AppDbContext.Set<ToDoItem>().AddRangeAsync(ToDoItems, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
