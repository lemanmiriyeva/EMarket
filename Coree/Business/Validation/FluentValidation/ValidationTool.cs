using FluentValidation;

namespace Coree.Business.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
