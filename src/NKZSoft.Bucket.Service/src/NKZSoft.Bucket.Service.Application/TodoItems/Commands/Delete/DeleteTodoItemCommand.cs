namespace NKZSoft.Bucket.Service.Application.TodoItems.Commands.Delete;

public sealed record DeleteTodoItemCommand(Guid Id)  : IRequest;
