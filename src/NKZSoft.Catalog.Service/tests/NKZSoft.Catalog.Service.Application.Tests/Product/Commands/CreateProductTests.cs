namespace NKZSoft.Catalog.Service.Application.Tests.Product.Commands;

using Application.Product.Commands.Create;

[Collection("QueryCollection")]
[Trait("TestType", "Unit")]
[Trait("Module", "Catalog")]
public sealed class CreateProductTests : TestBase
{
    private const string ProductTitle = "iPhone 14";

    public CreateProductTests(QueryTestFixture fixture) : base(fixture)
    {
    }

    [Fact]
    public async Task ShouldCreateProduct()
    {
        var command = new CreateProductCommand(ProductTitle, 799);
        var result = await Mediator.Send(command);

        result.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();
    }
}
