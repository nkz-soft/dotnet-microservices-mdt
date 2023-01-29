namespace NKZSoft.Catalog.Service.Application.Product.Commands.Create;

public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(v => v.Name)
            .MaximumLength(250)
            .NotEmpty();
    }
}
