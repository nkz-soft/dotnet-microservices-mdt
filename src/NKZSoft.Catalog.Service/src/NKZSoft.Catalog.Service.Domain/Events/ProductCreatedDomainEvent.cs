namespace NKZSoft.Catalog.Service.Domain.Events;

public sealed record ProductCreatedDomainEvent(Guid Id, string Name, decimal Price) : INotification;
