using HopeChurchWeb.Common.Enum;
using HopeChurchWeb.Models;
using HopeChurchWeb.Repository;
using Serilog;
using HopeChurchWeb.Helper;

namespace HopeChurchWeb.Services;

public class LoginService
{
    private readonly LoginRepository _loginRepository;

    public LoginService(LoginRepository loginRepository)
    {
        _loginRepository = loginRepository;
    }

    public ServiceResponse UserSighUp(FormSignup formSignup)
    {
        try
        {
            var validationResult = ModelHelper.ValidateModel<FormSignup>(formSignup);
            if (!validationResult.Success)
            {
                return validationResult;
            }

            // 如果驗證通過，繼續處理註冊邏輯
            // ... 您的註冊邏輯 ...

            return new ServiceResponse(true, "註冊成功");
        }
        catch (Exception e)
        {
            Log.Error(e, "Service: LoginService, Function: UserSighUp");
            return new ServiceResponse(false, e.Message);
        }
    }

    

    public ServiceResponse CheckUserExist(FormLogin form)
    {
        try
        {
            var loginMode = Enum.Parse<LoginModeEnum>(form.LoginMode, true);

            var response = loginMode switch
            {
                LoginModeEnum.Church => AuthenticateChurchAccount(form),
                LoginModeEnum.CGM => AuthenticateCgmAccount(form),
                _ => new ServiceResponse(false, "未知的登入模式")
            };

            return response;
        }
        catch (Exception e)
        {
            Log.Error(e, "Service: LoginService, Function: CheckUserExist");
            return new ServiceResponse(false, e.Message);
        }
    }

    private ServiceResponse AuthenticateChurchAccount(FormLogin form)
    {
        var user = _loginRepository.SelectUserMains()
            .FirstOrDefault(user => user.Account == form.Account);
        if (user == null) return new ServiceResponse(false, "不存在的帳號");

        return user.Password != form.Password ? new ServiceResponse(false, "密碼錯誤") : new ServiceResponse(true, "登入成功");
    }

    private ServiceResponse AuthenticateCgmAccount(FormLogin form)
    {
        return new ServiceResponse(true, "登入成功");
    }
}