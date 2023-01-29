namespace NKZSoft.Catalog.Service.Application.Product.Specifications;

using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

public sealed class ProductByIdSpecification : Specification<Product>, ISingleResultSpecification<Product>
{
    public ProductByIdSpecification(Guid id, bool noTracking = false)
    {
        Query.Where(i => i.Id == id);
        if (noTracking)
        {
            Query.AsNoTracking();
        }
    }
}
