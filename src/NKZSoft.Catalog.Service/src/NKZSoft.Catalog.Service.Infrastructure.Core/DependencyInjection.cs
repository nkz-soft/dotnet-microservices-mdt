﻿namespace NKZSoft.Catalog.Service.Infrastructure.Core;

using Services;

public static class DependencyInjection
{
    public static IServiceCollection AddCoreInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IDateTime, MachineDateTime>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<ICurrentUser, CurrentUser>();

        return services;
    }
}
