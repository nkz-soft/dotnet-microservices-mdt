namespace NKZSoft.Catalog.Service.Application.Product.Queries.GetPage;

using Common.Handlers;
using Common.Interfaces;
using Common.Paging;
using Common.Repositories;
using NKZSoft.Catalog.Service.Application.Models;
using Specifications;

public sealed class GetPageTodoQueryHandler :
    PagingQueryHandler<GetPageProductsQuery, Result<CollectionViewModel<ProductDto>>, ProductDto>
{
    private readonly IProductRepository _repository;

    public GetPageTodoQueryHandler(
        IProductRepository repository,
        IApplicationDbContext context,
        ICurrentUserService currentUserService, IMapper mapper) : base(context, mapper, currentUserService) =>
        _repository = repository.ThrowIfNull();

    public override async Task<Result<CollectionViewModel<ProductDto>>> Handle(GetPageProductsQuery request,
        CancellationToken cancellationToken)
    {
        var specification = ProductSpecification.Create(request.PageContext);

        var entities = await _repository
            .ListAsync(specification, cancellationToken)
            .ConfigureAwait(false);

        var dtoItems = await entities
            .BuildAdapter(Mapper.Config)
            .AdaptToTypeAsync<List<ProductDto>>()
            .ConfigureAwait(false);

        return Result.Ok(new CollectionViewModel<ProductDto>(
            dtoItems, dtoItems.Count));
    }
}
