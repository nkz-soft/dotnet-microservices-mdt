namespace NKZSoft.Payment.Service.Application.Models;

using Common.Models;

public sealed record ToDoListDto(int Id, string Title, string CreatedBy, DateTime Created, string ModifiedBy, DateTime? Modified, DateTime? Deleted)
    : BaseDto(CreatedBy, Created, ModifiedBy, Modified, Deleted)
{
    public IReadOnlyCollection<ToDoItemDto> ToDoItems { get; init; } = Enumerable.Empty<ToDoItemDto>().ToList();
}
