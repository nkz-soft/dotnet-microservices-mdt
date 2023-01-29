namespace NKZSoft.Order.Service.Application.TodoItems.Specifications;

public sealed class ToDoItemByIdSpecification : Specification<ToDoItem>, ISingleResultSpecification<ToDoItem>
{
    public ToDoItemByIdSpecification(Guid id, bool noTracking = false)
    {
        Query.Where(i => i.Id == id);
        if (noTracking)
        {
            Query.AsNoTracking();
        }
    }
}
