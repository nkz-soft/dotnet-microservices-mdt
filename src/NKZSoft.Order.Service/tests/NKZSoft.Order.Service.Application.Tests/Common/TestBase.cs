using NKZSoft.Order.Service.Application.Common.Interfaces;
using NKZSoft.Order.Service.Application.Tests.SeedData;

namespace NKZSoft.Order.Service.Application.Tests.Common;

public class TestBase
{
    protected IApplicationDbContext Context { get; init; }

    protected ICurrentUserService CurrentUserService { get;init; }
    
    protected SeedDataContext SeedDataContext { get; init; }

    protected IMediator Mediator { get; init; }

    protected TestBase(QueryTestFixture fixture)
    {
        Context = fixture.Context;
        Mediator = fixture.Mediator;
        CurrentUserService = fixture.CurrentUserService;
        SeedDataContext = fixture.SeedDataContext;
    }
}
