namespace NKZSoft.Catalog.Service.Application.Product.Queries.GetPage;

using Common.Paging;
using NKZSoft.Catalog.Service.Application.Models;
using Models;

public sealed class GetPageProductsQuery : PagingQuery<Result<CollectionViewModel<ProductDto>>, ProductFilter>
{
    public GetPageProductsQuery(PageContext<ProductFilter> pageContext) : base(pageContext)
    {
    }

    public static GetPageProductsQuery Create(PageContext<ProductFilter> pageContext) => new(pageContext);
}
