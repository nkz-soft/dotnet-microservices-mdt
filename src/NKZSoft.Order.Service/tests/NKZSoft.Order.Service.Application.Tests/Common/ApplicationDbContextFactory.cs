using Microsoft.EntityFrameworkCore;
using NKZSoft.Order.Service.Application.Common.Interfaces;
using NKZSoft.Order.Service.Application.Tests.SeedData;
using NKZSoft.Order.Service.Common.Tests;
using NKZSoft.Order.Service.Infrastructure.Core.Services;
using NKZSoft.Order.Service.Persistence.PostgreSQL;

namespace NKZSoft.Order.Service.Application.Tests.Common;

public static class ApplicationDbContextFactory
{
    public static async Task<IApplicationDbContext> CreateAsync()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new ApplicationDbContext(options);
        context.InitContext(
            AppMockFactory.CreateCurrentUserServiceMock(),
            new SeedDataContext(),
            new MachineDateTime(),
            AppMockFactory.CreateMediatorMock());

        await context.Database.EnsureCreatedAsync();
        await context.SeedAsync();

        return context;
    }

    public static void Destroy(IApplicationDbContext context)
    {
        context.AppDbContext.Database.EnsureDeleted();

        context.AppDbContext.Dispose();
    }
}
