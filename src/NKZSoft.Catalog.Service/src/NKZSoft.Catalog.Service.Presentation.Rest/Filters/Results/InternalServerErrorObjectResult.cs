namespace NKZSoft.Catalog.Service.Presentation.Rest.Filters.Results;

public sealed class InternalServerErrorObjectResult : ObjectResult
{
    public InternalServerErrorObjectResult(object? value) : base(value)
    {
    }
}
