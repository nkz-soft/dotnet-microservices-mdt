namespace NKZSoft.Catalog.Service.Domain.Common;

public abstract class BaseAuditableEntity<TPKey, TUserPKey> : BaseEntity<TPKey>, IBaseAuditableEntity<TUserPKey>
{
    protected BaseAuditableEntity(TPKey id) : base(id)
    {
    }

    public DateTime? Created { get; set; }

    public TUserPKey? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public TUserPKey? ModifiedBy { get; set; }
}
