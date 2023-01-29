namespace NKZSoft.Catalog.Service.Domain.Common;

public interface IEntity
{
    IReadOnlyCollection<INotification> DomainEvents { get; }

    void AddDomainEvent(INotification domainEvent);

    void RemoveDomainEvent(INotification domainEvent);

    void ClearDomainEvents();
}
