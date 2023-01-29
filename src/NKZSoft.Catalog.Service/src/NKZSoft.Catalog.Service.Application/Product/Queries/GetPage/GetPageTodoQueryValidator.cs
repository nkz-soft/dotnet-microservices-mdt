namespace NKZSoft.Catalog.Service.Application.Product.Queries.GetPage;

using Models;
using Common.Paging;
using NKZSoft.Catalog.Service.Application.Models;

public sealed class GetPageTodoQueryValidator
    : PagingQueryValidator<GetPageProductsQuery, Result<CollectionViewModel<ProductDto>>,ProductFilter>
{
}
