namespace NKZSoft.Catalog.Service.Application.Product.Queries.Get;

public sealed class GetProductQueryValidator : AbstractValidator<GetProductQuery>
{
    public GetProductQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");
    }
}
