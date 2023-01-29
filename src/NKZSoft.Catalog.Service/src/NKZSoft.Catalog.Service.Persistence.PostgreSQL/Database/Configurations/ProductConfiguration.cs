namespace NKZSoft.Catalog.Service.Persistence.PostgreSQL.Database.Configurations;

using Domain.AggregatesModel.ProductAggregates.Entities;

public class ProductConfiguration : AuditableConfiguration<Product>, IEntityTypeConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);

        builder.ToTable("Products");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(e => e.Price)
            .IsRequired();
    }
}
