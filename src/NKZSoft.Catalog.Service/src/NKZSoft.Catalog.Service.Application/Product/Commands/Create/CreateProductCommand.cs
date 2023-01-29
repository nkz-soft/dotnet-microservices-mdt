namespace NKZSoft.Catalog.Service.Application.Product.Commands.Create;

public sealed record CreateProductCommand(string Name, decimal price) : IRequest<Result<Guid>>;
