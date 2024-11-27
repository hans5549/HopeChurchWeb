using HopeChurchWeb.Models.LoginSignup;
using Microsoft.AspNetCore.Components;

namespace HopeChurchWeb.Components.Pages.Login;

public partial class LoginPage : ComponentBase
{
    private FormLogin _login = new();

    private void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }
}