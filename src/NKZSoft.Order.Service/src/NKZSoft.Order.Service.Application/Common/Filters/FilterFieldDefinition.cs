namespace NKZSoft.Order.Service.Application.Common.Filters;

public sealed record FilterFieldDefinition<T>
{
    public T? Value { get; init; }
}