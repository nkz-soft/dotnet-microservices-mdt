namespace NKZSoft.Catalog.Service.Application.Product.Queries.Get;

using Common.Exceptions;
using Common.Handlers;
using Common.Interfaces;
using Common.Repositories;
using NKZSoft.Catalog.Service.Application.Models;
using Specifications;

public sealed class GetProductQueryHandler : HandlerQueryBase<GetProductQuery, Result<ProductDto>>
{
    private readonly IProductRepository _repository;

    public GetProductQueryHandler(
        IProductRepository repository,
        IApplicationDbContext applicationDbContext,
        ICurrentUserService currentUserService,
        IMapper mapper)
        : base(applicationDbContext, mapper, currentUserService) =>
        _repository = repository.ThrowIfNull();

    public override async Task<Result<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository
            .SingleOrDefaultAsync(new ProductByIdSpecification(request.Id, true), cancellationToken)
            .ConfigureAwait(false);

        entity.ThrowIfNull(new NotFoundException());

        var dtoItem = await entity
            .BuildAdapter(Mapper.Config)
            .AdaptToTypeAsync<ProductDto>()
            .ConfigureAwait(false);

        return Result.Ok(dtoItem);
    }
}
