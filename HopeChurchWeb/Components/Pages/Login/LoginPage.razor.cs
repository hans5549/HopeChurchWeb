using HopeChurchWeb.Common.Enum;
using HopeChurchWeb.Models.LoginSignup;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.Login;

public partial class LoginPage : ComponentBase
{
    private bool _showPassword = false;
    private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
    private FormLogin _login = new();
    private InputType _passwordInputType = InputType.Password;
    private string _selectedMode = LoginModeEnum.Church.ToString();

    private void HandlePasswordInputIconClick()
    {
        if (_showPassword)
        {
            _showPassword = false;
            _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
            _passwordInputType = InputType.Password;
        }
        else
        {
            _showPassword = true;
            _passwordInputIcon = Icons.Material.Filled.Visibility;
            _passwordInputType = InputType.Text;
        }
    }

    private void HandleSubmit()
    {
        Console.WriteLine(_login.Account);
    }
}