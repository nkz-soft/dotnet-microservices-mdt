namespace NKZSoft.Payment.Service.Application.TodoItems.Commands.Update;

public sealed record UpdateTodoItemCommand(Guid Id, string Title, string Description) : IRequest;
