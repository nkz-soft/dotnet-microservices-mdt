namespace NKZSoft.Catalog.Service.Persistence.PostgreSQL.Database.Configurations;

public class AuditableConfiguration<T> where T : class, IBaseAuditableEntity<Guid>
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(e => e.Created)
            .IsRequired();

        builder.Property(e => e.CreatedBy)
            .IsRequired();

        builder.Property(e => e.Modified);

        builder.Property(e => e.ModifiedBy);
    }
}
