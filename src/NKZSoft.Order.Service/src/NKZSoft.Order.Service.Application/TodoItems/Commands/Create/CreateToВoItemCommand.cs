namespace NKZSoft.Order.Service.Application.TodoItems.Commands.Create;

public sealed record CreateToDoItemCommand(string Title, int? ListId) : IRequest<Result<Guid>>;
