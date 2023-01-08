namespace NKZSoft.Catalog.Service.Presentation.REST.Controllers.Version10;

using Application.Models;
using Application.Product.Commands.Create;
using Application.Product.Models;
using Application.Product.Queries.Get;
using Application.Product.Queries.GetPage;
using Domain.AggregatesModel.ProductAggregates.Entities;
using Models.Result;

[ApiVersion(VersionController.Version10)]
[Route("api/v{version:apiVersion}/products")]
public class ProductControllerV1 : BaseController
{
    public ProductControllerV1(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    [Route("page")]
    [ProducesResponseType(typeof(ResultDto<CollectionViewModel<Product>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ResultDto<CollectionViewModel<ProductDto>>>> Page(
        [FromBody]PageContext<ProductFilter> pageContext,
        CancellationToken cancellationToken)
        => (await Mediator.Send(GetPageProductsQuery.Create(pageContext), cancellationToken)).ToResultDto();

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResultDto<Product>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ResultDto<ProductDto>>> Get(Guid id, CancellationToken cancellationToken)
        => (await Mediator.Send(new GetProductQuery(id), cancellationToken)).ToResultDto();

    [HttpPost]
    [ProducesResponseType(typeof(ResultDto<Guid>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ResultDto<Unit>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ResultDto<Guid>>> Create(
        [FromBody] CreateProductCommand command,
        CancellationToken cancellationToken)
        => (await Mediator.Send(command, cancellationToken)).ToResultDto();
}
