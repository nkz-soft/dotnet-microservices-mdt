using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NKZSoft.Order.Service.Common.Tests;

namespace NKZSoft.Order.Service.Application.Tests;

internal sealed class Startup
{
    public static async void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication();
        services.TryAddSingleton(AppMockFactory.CreateCurrentUserServiceMock());
        services.TryAddSingleton(await ApplicationDbContextFactory.CreateAsync());

        services.TryAddScoped<IToDoItemRepository, ToDoItemRepository>();
        services.TryAddScoped<IToDoListRepository, ToDoListRepository>();
    }
}
