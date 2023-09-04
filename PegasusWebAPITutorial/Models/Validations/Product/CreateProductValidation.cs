using FluentValidation;
using PegasusWebAPITutorial.Models.DTO.Product;

namespace PegasusWebAPITutorial.Models.Validations.Product
{
    public class CreateProductValidation : AbstractValidator<CreateProductRequestDto>
    {
        public CreateProductValidation()
        {
            RuleFor(product => product.UnitPrice).NotEmpty();

        }
    }
}
