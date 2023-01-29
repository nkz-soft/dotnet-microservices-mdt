[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCaseOrderer("Xunit.Extensions.Ordering.TestCaseOrderer", "Xunit.Extensions.Ordering")]
[assembly: TestCollectionOrderer("Xunit.Extensions.Ordering.CollectionOrderer", "Xunit.Extensions.Ordering")]

namespace NKZSoft.Catalog.Service.Presentation.Rest.Tests.Controllers;

using Common;
using NKZSoft.Catalog.Service.Presentation.Rest.Models.Result;

[Collection(nameof(RestCollectionDefinition))]
[Trait("TestType", "Integration")]
[Trait("Module", "Catalog")]
public sealed class ProductControllerTest
{
    private const string ApiUrlBaseV1 = "api/v1/products";

    private readonly RestWebApplicationFactory<Program> _factory;

    public ProductControllerTest(RestWebApplicationFactory<Program> factory) => _factory = factory;

    private static class Get
    {
        public static string GetProduct(Guid id) => $"{ApiUrlBaseV1}/{id}";
    }

    private static class Post
    {
        public static string GetPageProduct() => $"{ApiUrlBaseV1}/page";
        public static string CreateProduct() => $"{ApiUrlBaseV1}";
    }

    [Fact, Order(1)]
    public async Task<ResultDto<CollectionViewModel<ProductDto>>> GetPageTestAsync()
    {
        var client = new RestClient(_factory.CreateClient());

        var command = new PageContext<ProductFilter>(1, 10);

        var response = await client.PostAsync<ResultDto<CollectionViewModel<ProductDto>>>(
            new RestRequest (Post.GetPageProduct()).AddJsonBody(command));

        response.Should().NotBeNull();
        response.Should().BeOfType<ResultDto<CollectionViewModel<ProductDto>>>();
        response!.IsSuccess.Should().BeTrue();

        response.Data.Should().NotBeNull();
        response.Data.Data.Should().HaveCount(5);

        return response;
    }

    [Fact, Order(2)]
    public async Task GetByIdTestAsync()
    {
        var items = await GetPageTestAsync();
        var firstItem = items.Data.Data.First();

        var client = new RestClient(_factory.CreateClient());

        var response = await client.GetAsync<ResultDto<ProductDto>>(
            new RestRequest(Get.GetProduct(firstItem.Id)));

        response.Should().NotBeNull();
        response.Should().BeOfType<ResultDto<ProductDto>>();
        response!.IsSuccess.Should().BeTrue();

        response.Data.Should().NotBeNull();
        response.Data.Name.Should().Be(firstItem.Name);
        response.Data.Price.Should().Be(firstItem.Price);
    }

    [Fact, Order(3)]
    public async Task GetByIdNotFoundTestAsync()
    {
        var client = new RestClient(_factory.CreateClient());

        var response = await client.GetAsync<ResultDto<Unit>>(
            new RestRequest(Get.GetProduct(Guid.NewGuid())));

        response.Should().NotBeNull();
        response.Should().BeOfType<ResultDto<Unit>>();
        response!.IsSuccess.Should().BeFalse();
    }

    [Fact, Order(4)]
    public async Task CreateTestAsync()
    {
        var client = new RestClient(_factory.CreateClient());

        var command = new CreateProductCommand("Test_Product_1", 10) ;

        var response = await client.PostAsync<ResultDto<Guid>>(
            new RestRequest(Post.CreateProduct()).AddJsonBody(command));

        response.Should().NotBeNull();
        response.Should().BeOfType<ResultDto<Guid>>();
        response!.IsSuccess.Should().BeTrue();
    }
}
