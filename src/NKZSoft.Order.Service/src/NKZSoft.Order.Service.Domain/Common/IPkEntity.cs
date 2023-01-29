namespace NKZSoft.Order.Service.Domain.Common;

public interface IPkEntity<out TKey> : IEntity
{
    public TKey Id { get; }
}
