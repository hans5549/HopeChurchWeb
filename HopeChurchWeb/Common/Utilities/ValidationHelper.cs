using System.ComponentModel.DataAnnotations;
using HopeChurchWeb.Models;

namespace HopeChurchWeb.Common.Utilities;

public static class ValidationHelper
{
    public static ServiceResponse ValidateModel<T>(T model) where T : class
    {
        var validationContext = new ValidationContext(model);
        var validationResults = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);

        if (!isValid)
        {
            var errors = validationResults
                .Select(x => x.ErrorMessage)
                .ToList();
            
            return new ServiceResponse(false, string.Join(", ", errors));
        }

        return new ServiceResponse(true, "驗證通過");
    }
} 