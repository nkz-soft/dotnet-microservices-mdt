namespace NKZSoft.Catalog.Service.Presentation.REST.Filters.Results;

public sealed class BadRequestValidationObjectResult : BadRequestObjectResult
{
    public BadRequestValidationObjectResult(object? error) : base(error)
    {
    }

    public BadRequestValidationObjectResult(ModelStateDictionary modelState) : base(modelState)
    {
    }
}
