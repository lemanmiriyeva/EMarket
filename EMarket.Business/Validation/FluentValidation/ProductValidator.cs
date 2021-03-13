using EMarket.Entity.Concrete;
using FluentValidation;

namespace EMarket.Business.Validation.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).Length(3, 20).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.StockAmount).GreaterThanOrEqualTo((short)0).NotEmpty();
            RuleFor(p => p.CategoryId).InclusiveBetween(1, 4).NotEmpty();
            //RuleFor(p => p.ProductName).Must(StartWithA).When(p=>p.CategoryId==1).WithMessage("Must start with a");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.ToLower().StartsWith("a");
        //}
    }
}
