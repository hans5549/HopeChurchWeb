using HopeChurchWeb.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.Login;

public partial class SignupPage : ComponentBase
{
    #region [Inject]

    [Inject]
    private NavigationManager NavigationManager { get; set; } = null!;

    #endregion

    private bool _showPassword = false;
    private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
    private FormSignup _formSignup = new();
    private InputType _passwordInputType = InputType.Password;

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

    private void HandleLoginClick()
    {
        NavigationManager.NavigateTo("/login");
    }

    private void HandleSubmitClick()
    {
        Console.WriteLine(_formSignup.Account);
    }
}