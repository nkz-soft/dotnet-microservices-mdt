namespace NKZSoft.Order.Service.Events.Event.ToDoItem.Update;

using Interfaces;

public sealed record ToDoItemUpdatedIntegrationEvent(Guid Id, string Name) : IIntegrationEvent;
