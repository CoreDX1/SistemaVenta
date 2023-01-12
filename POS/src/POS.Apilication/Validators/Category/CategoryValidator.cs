using FluentValidation;
using POS.Apilication.Dtos.Response;

namespace POS.Apilication.Validators.Category;

public class CategoryValidator : AbstractValidator<CategoryReponseDto>
{
    public CategoryValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .WithMessage("El capo Nombre no puede ser nulo")
            .NotEmpty()
            .WithMessage("El campo Nombre no pude ser vacio");
    }
}
