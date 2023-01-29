namespace NKZSoft.Catalog.Service.Application.Product.Models;

using Common.Filters;

public partial record ProductFilter
{
    public FilterFieldDefinition<Guid>? Id { get; set; }

    public FilterFieldDefinition<string>? Name { get; set; }
}
