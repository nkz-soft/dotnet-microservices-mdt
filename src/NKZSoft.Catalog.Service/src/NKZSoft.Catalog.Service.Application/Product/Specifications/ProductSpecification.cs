namespace NKZSoft.Catalog.Service.Application.Product.Specifications;

using NKZSoft.Catalog.Service.Application.Common.Exceptions;
using NKZSoft.Catalog.Service.Application.Common.Filters;
using NKZSoft.Catalog.Service.Application.Common.Paging;
using NKZSoft.Catalog.Service.Application.Product.Models;
using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

public sealed class ProductSpecification : Specification<Product>
{
    private static readonly IDictionary<string, Expression<Func<Product, object>>> SortExpressions =
        new Dictionary<string, Expression<Func<Product, object>>>(StringComparer.OrdinalIgnoreCase)
        {
            { nameof(ProductFilter.Id), c => c.Id },
            { nameof(ProductFilter.Name), c => c.Name },
        };

    private ProductSpecification()
    {
    }

    public static Specification<Product> Create(IPageContext<ProductFilter> pageContext)
    {
        var specification =  new ProductSpecification();

        var specificationBuilder = specification.Query;

        Filter(specificationBuilder, pageContext.Filter);
        specification.Sort(specificationBuilder, pageContext.ListSort);

        if (pageContext.PageIndex != 0)
        {
            specificationBuilder.Skip(pageContext.PageSize * (pageContext.PageIndex - 1));
        }

        if (pageContext.PageSize != 0)
        {
            specificationBuilder.Take(pageContext.PageSize);
        }

        specificationBuilder.AsNoTracking();
        return specification;
    }

    private static void Filter(ISpecificationBuilder<Product> specificationBuilder, ProductFilter filter)
    {
        if (filter.Name.HasValue())
        {
            specificationBuilder.Where(x => x.Name == filter.Name.Value);
        }

        if (filter.Id.HasValue())
        {
            specificationBuilder.Where(x => x.Id == filter.Id.Value);
        }
    }

    private ISpecificationBuilder<Product> Sort(ISpecificationBuilder<Product> specificationBuilder,
        IEnumerable<SortDescriptor> sorts)
    {
        var sortDescriptors = sorts as SortDescriptor[] ?? sorts.ToArray();

        if (sortDescriptors.Any())
        {
            return sortDescriptors.Aggregate(specificationBuilder, Sort);
        }

        return Sort(specificationBuilder, new SortDescriptor(nameof(ProductFilter.Id)));
    }

    private ISpecificationBuilder<Product> Sort(ISpecificationBuilder<Product> specificationBuilder,
        SortDescriptor sort)
    {
        if (SortExpressions.TryGetValue(sort.Field, out var se))
        {
            return sort.Direction == EnumSortDirection.Desc
                ? specificationBuilder.OrderByDescending(se!)
                : specificationBuilder.OrderBy(se!);
        }
        throw new BadRequestException($"Invalid field name {sort.Field}.");
    }
}
