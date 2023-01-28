namespace NKZSoft.Order.Service.Presentation.Rest.Controllers;

[ApiController]
[Produces("application/json")]
public abstract class BaseController : ControllerBase
{
    protected BaseController(IMediator mediator) => Mediator = mediator.ThrowIfNull();

    protected IMediator Mediator { get; }
}