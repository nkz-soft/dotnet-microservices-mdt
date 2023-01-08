namespace NKZSoft.Catalog.Service.Presentation.REST.Filters.Results;

public sealed class ForbiddenObjectResult : ObjectResult
{
    public ForbiddenObjectResult(object? value) : base(value)
    {
    }
}
