namespace NKZSoft.Payment.Service.Domain.Common;

public interface IPkEntity<out TKey> : IEntity
{
    public TKey Id { get; }
}
