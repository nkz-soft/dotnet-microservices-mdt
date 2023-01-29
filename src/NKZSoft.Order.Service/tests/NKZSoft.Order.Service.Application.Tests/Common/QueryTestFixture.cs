using NKZSoft.Order.Service.Application.Common.Interfaces;
using NKZSoft.Order.Service.Application.Tests.SeedData;
using NKZSoft.Order.Service.Common;
using NKZSoft.Order.Service.Common.Tests;

namespace NKZSoft.Order.Service.Application.Tests.Common;

public sealed class QueryTestFixture : IDisposable
{
    public IMediator Mediator { get; }

    public IApplicationDbContext Context { get; }

    public ICurrentUserService CurrentUserService { get; }

    public SeedDataContext SeedDataContext { get; set; } = new SeedDataContext();

    public QueryTestFixture(IApplicationDbContext context, ICurrentUserService currentUserService, IMediator mediator)
    {
        Context = context.ThrowIfNull();
        Mediator = mediator.ThrowIfNull();
        CurrentUserService = currentUserService.ThrowIfNull();
    }

    public void Dispose() => ApplicationDbContextFactory.Destroy(Context);
}
