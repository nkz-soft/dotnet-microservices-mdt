namespace NKZSoft.Catalog.Service.Application.Tests.SeedData;

using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

public sealed partial class SeedDataContext
{
    public static IEnumerable<Product> Products
    {
        get
        {
            yield return new Product("Test_Product_1", 1);
            yield return new Product("Test_Product_2", 2);
            yield return new Product("Test_Product_3", 3);
            yield return new Product("Test_Product_4", 4);
            yield return new Product("Test_Product_5", 5);
        }
    }
}
