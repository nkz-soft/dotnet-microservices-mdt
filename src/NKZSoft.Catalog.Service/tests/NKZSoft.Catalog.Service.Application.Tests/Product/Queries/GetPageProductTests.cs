namespace NKZSoft.Catalog.Service.Application.Tests.TodoItems.Queries;

using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

[Collection("QueryCollection")]
[Trait("TestType", "Unit")]
[Trait("Module", "Catalog")]
public sealed class GetPageProductTests : TestBase
{
    private const string TestItemTitle = "Test_Product_1";

    public GetPageProductTests(QueryTestFixture fixture) : base(fixture)
    {
    }

    [Theory]
    [InlineData(1, 3)]
    public async Task ShouldReturnItemPage(int pageIndex, int pageSize)
    {
        var command = new GetPageProductsQuery(new PageContext<ProductFilter>(pageIndex, pageSize));
        var result = await Mediator.Send(command);

        result.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.TotalCount.Should().Be(pageSize);
    }

    [Theory]
    [InlineData(1, 10)]
    public async Task ShouldReturnItemPageById(int pageIndex, int pageSize)
    {
        var firstEntity = Context.Set<Product>().First();

        var command = new GetPageProductsQuery(new PageContext<ProductFilter>
            (pageIndex, pageSize, ProductFilter.CreateBuilder().Id(firstEntity.Id).Build()));

        var result = await Mediator.Send(command);

        result.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.Data.FirstOrDefault().Should().NotBeNull();
        result.Value.Data.Count().Should().Be(1);
        result.Value.Data.First().Id.Should().Be(firstEntity.Id);
    }

    [Theory]
    [InlineData(1, 10, "Test_Product_1")]
    public async Task ShouldReturnItemPageByName(int pageIndex, int pageSize, string title)
    {
        var command = new GetPageProductsQuery(new PageContext<ProductFilter>(pageIndex, pageSize,
            ProductFilter.CreateBuilder().Name(title).Build()));

        var result = await Mediator.Send(command);

        result.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.Data.FirstOrDefault().Should().NotBeNull();
        result.Value.Data.Count().Should().Be(1);
        result.Value.Data.First().Name.Should().Be(TestItemTitle);
    }

    [Theory]
    [InlineData(1, 10, "Test_Product_5")]
    public async Task ShouldReturnItemPageSorting(int pageIndex, int pageSize, string title)
    {
        var command = new GetPageProductsQuery(new PageContext<ProductFilter>(pageIndex, pageSize)
        {
            ListSort = new[] { new SortDescriptor(nameof(Product.Name), EnumSortDirection.Desc) }
        });

        var result = await Mediator.Send(command);

        result.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.Data.FirstOrDefault().Should().NotBeNull();
        result.Value.Data.First().Name.Should().Be(title);
    }
}
