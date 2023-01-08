namespace NKZSoft.Catalog.Service.Application.Product.Commands.Create;

using Common.Repositories;
using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result<Guid>>
{
    private readonly IProductRepository _repository;

    public CreateProductCommandHandler(IProductRepository repository) => _repository = repository.ThrowIfNull();

    public async Task<Result<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product(request.Name, request.price);

        await _repository
            .AddAsync(entity, cancellationToken)
            .ConfigureAwait(false);

        await _repository.SaveChangesAsync(cancellationToken)
            .ConfigureAwait(false);

        return Result.Ok(entity.Id);
    }
}
