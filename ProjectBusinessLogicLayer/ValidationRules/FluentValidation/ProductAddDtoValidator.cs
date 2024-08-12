using FluentValidation;
using ProjectBusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.ValidationRules.FluentValidation
{
    public class ProductAddDtoValidator : AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(x => x.ProductName)
            .NotNull()
            .NotEmpty()
            .WithMessage("Name is not empty");
            RuleFor(x => x.Price).GreaterThan(10).LessThan(100000).WithMessage("Price must be between 10  and 100000");
            RuleFor(x => x.StockCount).NotNull();

        }
    }
}
