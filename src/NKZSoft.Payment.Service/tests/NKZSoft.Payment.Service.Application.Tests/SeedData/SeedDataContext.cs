using NKZSoft.Payment.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
using NKZSoft.Payment.Service.Persistence.PostgreSQL;

namespace NKZSoft.Payment.Service.Application.Tests.SeedData;

using Application.Common.Interfaces;

public sealed partial class SeedDataContext : IDbInitializer
{
    public async Task SeedAsync(IApplicationDbContext context, CancellationToken cancellationToken)
    {
        await context.AppDbContext.Set<ToDoItem>().AddRangeAsync(ToDoItems, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
