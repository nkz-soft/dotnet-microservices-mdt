﻿namespace NKZSoft.Bucket.Service.Application.TodoItems.Queries.GetPage;

using Application.Models;
using Common.Paging;
using Models;

public sealed class GetPageTodoItemsQuery : PagingQuery<Result<CollectionViewModel<ToDoItemDto>>, ToDoItemFilter>
{
    public GetPageTodoItemsQuery(PageContext<ToDoItemFilter> pageContext) : base(pageContext)
    {
    }

    public static GetPageTodoItemsQuery Create(PageContext<ToDoItemFilter> pageContext) => new(pageContext);
}
