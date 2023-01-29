﻿namespace NKZSoft.Catalog.Service.Persistence.PostgreSQL;

public class ApplicationDbDesignTimeContextFactory : DesignTimeDbContextFactoryBase<ApplicationDbContext>
{
    protected override ApplicationDbContext CreateNewInstance(DbContextOptions<ApplicationDbContext> options)
    {
        return new ApplicationDbContext(options);
    }
}
