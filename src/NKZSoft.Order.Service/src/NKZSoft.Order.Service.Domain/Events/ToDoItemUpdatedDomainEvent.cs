namespace NKZSoft.Order.Service.Domain.Events;

public sealed record ToDoItemUpdatedDomainEvent(Guid Id, string Name, string? Note) : INotification;
