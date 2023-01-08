namespace NKZSoft.Catalog.Service.Persistence.PostgreSQL.Repositories;

using Application.Common.Repositories;
using Domain.AggregatesModel.ProductAggregates.Entities;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(IApplicationDbContext dbContext) : base(dbContext.AppDbContext)
    {
    }

    public ProductRepository(IApplicationDbContext dbContext,
        ISpecificationEvaluator specificationEvaluator) : base(dbContext.AppDbContext, specificationEvaluator)
    {
    }
}
