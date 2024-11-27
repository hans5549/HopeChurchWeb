using Microsoft.AspNetCore.Components;

namespace HopeChurchWeb.Components.Layout;

public partial class MainLayout
{
    #region [Inject]
    [Inject]
    private NavigationManager Navigation { get; set; } = null!;
    #endregion

    private bool _drawerOpen = false;

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}