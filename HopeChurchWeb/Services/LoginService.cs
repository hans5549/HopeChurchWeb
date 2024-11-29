using HopeChurchWeb.Repository;

namespace HopeChurchWeb.Services;

public class LoginService
{
    private LoginRepository _loginRepository;

    public LoginService(LoginRepository loginRepository)
    {
        _loginRepository = loginRepository;
    }
}