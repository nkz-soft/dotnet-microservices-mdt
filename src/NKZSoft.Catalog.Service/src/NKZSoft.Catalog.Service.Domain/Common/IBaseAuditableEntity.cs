namespace NKZSoft.Catalog.Service.Domain.Common;

public interface IBaseAuditableEntity<TKey> : IEntity
{
    DateTime? Created { get; set; }

    TKey? CreatedBy { get; set; }

    DateTime? Modified { get; set; }

    TKey? ModifiedBy { get; set; }
}
