using HopeChurchWeb.Components.Pages.Login;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Layout;

public partial class MainLayout
{
    #region [Inject]
    [Inject]
    private IDialogService DialogService { get; set; } = null!;

    [Inject]
    private NavigationManager Navigation { get; set; } = null!;
    #endregion

    private bool _drawerOpen = false;
    private bool _menuShow = false;

    protected async Task InitializeAsync()
    {
        _drawerOpen = false;
        _menuShow = false;
    }

    private Task HandleLoginAsync()
    {
        DialogOptions options = new DialogOptions
        {
            FullWidth = true,
            CloseButton = true,
        };

        return DialogService.ShowAsync<LoginPage>("登入", options);
    }

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}