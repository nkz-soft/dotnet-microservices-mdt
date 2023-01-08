namespace NKZSoft.Catalog.Service.Application.Product.Models;

using Common.Filters;

public partial record ProductFilter
{
    public sealed class ProductFilterBuilder
    {
        private readonly ProductFilter _filter;

        public ProductFilterBuilder() => _filter = new ProductFilter();

        public ProductFilterBuilder Id(Guid id)
        {
            _filter.Id = new FilterFieldDefinition<Guid>() { Value = id };
            return this;
        }

        public ProductFilterBuilder Name(string title)
        {
            _filter.Name = new FilterFieldDefinition<string>() { Value = title };
            return this;
        }

        public ProductFilter Build() => _filter;
    }

    public static ProductFilterBuilder CreateBuilder() => new();
}
