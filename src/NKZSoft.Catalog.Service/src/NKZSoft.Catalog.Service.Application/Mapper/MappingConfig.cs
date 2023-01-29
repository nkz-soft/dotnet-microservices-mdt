namespace NKZSoft.Catalog.Service.Application.Mapper;

using Models;
using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

public class MappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductDto>();
    }
}
