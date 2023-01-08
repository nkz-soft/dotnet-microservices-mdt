namespace NKZSoft.Catalog.Service.Domain.Common;

public interface IPkEntity<out TKey> : IEntity
{
    public TKey Id { get; }
}
