using System.ComponentModel.DataAnnotations;
using HopeChurchWeb.Models;

namespace HopeChurchWeb.Helper;

public static class ModelHelper
{
    /// <summary>
    /// 通用模型驗證方法
    /// </summary>
    /// <typeparam name="T">要驗證的模型類型</typeparam>
    /// <param name="model">要驗證的模型實例</param>
    /// <returns>驗證結果</returns>
    public static ServiceResponse ValidateModel<T>(T model) where T : class
    {
        var validationContext = new ValidationContext(model);
        var validationResults = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);

        if (isValid) 
            return new ServiceResponse(true, "驗證通過");
        var errors = validationResults
            .Select(x => x.ErrorMessage)
            .ToList();
            
        return new ServiceResponse(false, string.Join(", ", errors));

    }
}