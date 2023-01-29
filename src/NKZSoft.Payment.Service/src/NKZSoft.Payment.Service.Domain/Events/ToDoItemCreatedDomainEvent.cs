namespace NKZSoft.Payment.Service.Domain.Events;

public sealed record ToDoItemCreatedDomainEvent(Guid Id, string Title, string? Note) : INotification;
