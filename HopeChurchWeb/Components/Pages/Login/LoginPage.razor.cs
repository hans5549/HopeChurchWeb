using HopeChurchWeb.Common.Enum;
using HopeChurchWeb.Models;
using HopeChurchWeb.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.Login;

public partial class LoginPage : ComponentBase
{
    #region [Inject]

    [Inject]
    private ISnackbar _snackbar { get; set; } = null!;

    [Inject]
    private LoginService _loginService { get; set; } = null!;

    [Inject]
    private NavigationManager _navigationManager { get; set; } = null!;

    #endregion

    private bool _showPassword = false;
    private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
    private FormLogin _formLogin = new();
    private InputType _passwordInputType = InputType.Password;
    //private string _selectedMode = LoginModeEnum.Church.ToString().ToLower();

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

    private void HandleForgetPasswordClick()
    {
        _navigationManager.NavigateTo("/forget-password");
    }

    private void HandleSignupClick()
    {
        _navigationManager.NavigateTo("/signup");
    }

    private void HandleSubmitClick()
    {
        ServiceResponse response = _loginService.CheckUserExist(_formLogin);
        if (response.Success)
        {
            SnackBarProcessing($"登入成功!", Severity.Success);
        }
        else
        {
            SnackBarProcessing($"登入失敗! {response.Message}", Severity.Error);
        }
    }

    private void SnackBarProcessing(string message, Severity severity)
    {
        _snackbar.Clear();
        _snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopRight;
        _snackbar.Add(message, severity);
    }
}