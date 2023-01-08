namespace NKZSoft.Catalog.Service.Application.Tests.Products.Queries;

using Application.Product.Queries.Get;
using Product = Domain.AggregatesModel.ProductAggregates.Entities.Product;

[Collection("QueryCollection")]
[Trait("TestType", "Unit")]
[Trait("Module", "Catalog")]
public sealed class GetProductTests : TestBase
{
    public GetProductTests(QueryTestFixture fixture) : base(fixture)
    {
    }

    [Fact]
    public async Task ShouldReturnItem()
    {
        var firstEntity = Context.Set<Product>().First();

        var command = new GetProductQuery(firstEntity.Id);
        var result = await Mediator.Send(command);

        result.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
    }
}
