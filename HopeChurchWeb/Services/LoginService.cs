using HopeChurchWeb.Common.Enum;
using HopeChurchWeb.Models;
using HopeChurchWeb.Repository;
using Serilog;

namespace HopeChurchWeb.Services;

public class LoginService
{
    private readonly LoginRepository _loginRepository;

    public LoginService(LoginRepository loginRepository)
    {
        _loginRepository = loginRepository;
    }

    public ServiceResponse CheckUserExist(FormLogin form)
    {
        try
        {
            LoginModeEnum loginMode = Enum.Parse<LoginModeEnum>(form.LoginMode, true);

            ServiceResponse response  = loginMode switch
            {
                LoginModeEnum.Church => AuthenticateChurchAccount(form),
                LoginModeEnum.CGM => AuthenticateCGMAccount(form),
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
        UserMain? user = _loginRepository.SelectUserMains()
            .FirstOrDefault(user => user.Account == form.Account);
        if (user == null)
        {
            return new ServiceResponse(false, "不存在的帳號");
        }

        return user.Password != form.Password ?
            new ServiceResponse(false, "密碼錯誤") :
            new ServiceResponse(true, "登入成功");
    }

    private ServiceResponse AuthenticateCGMAccount(FormLogin form)
    {
        return new ServiceResponse(true, "登入成功");
    }
}