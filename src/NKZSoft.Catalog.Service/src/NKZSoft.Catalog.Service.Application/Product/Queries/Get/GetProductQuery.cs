namespace NKZSoft.Catalog.Service.Application.Product.Queries.Get;

using NKZSoft.Catalog.Service.Application.Models;

public sealed record GetProductQuery(Guid Id) : IRequest<Result<ProductDto>>;
