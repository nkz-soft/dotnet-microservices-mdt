namespace NKZSoft.Catalog.Service.Domain.AggregatesModel.ProductAggregates.Entities;

using Common;
using Events;

public sealed class Product : BaseAuditableEntity<Guid, Guid>, IAggregateRoot
{
    public Product(string name, decimal price) : base( Guid.NewGuid())
    {
        Name = name;
        Price = price;

        AddCreateDomainEvent();
    }

    public string Name { get; private set; }

    public decimal Price { get; private set; }

    private void AddCreateDomainEvent()
    {
        var createEvent = new ProductCreatedDomainEvent(Id, Name, Price);
        AddDomainEvent(createEvent);
    }
}
