using NKZSoft.Catalog.Service.Application.Common.Interfaces;
using NKZSoft.Catalog.Service.Application.Tests.SeedData;
using NKZSoft.Catalog.Service.Common;
using NKZSoft.Catalog.Service.Common.Tests;

namespace NKZSoft.Catalog.Service.Application.Tests.Common;

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
