namespace NKZSoft.Catalog.Service.Presentation.REST.Tests.SeedData;

internal sealed partial class SeedDataContext
{
    public static IEnumerable<Product> Products
    {
        get
        {
            yield return new Product("Test_Product_1", 10);
            yield return new Product("Test_Product_2", 20);
            yield return new Product("Test_Product_3", 30);
            yield return new Product("Test_Product__4", 40);
            yield return new Product("Test_Product__5", 50);
        }
    }
}
