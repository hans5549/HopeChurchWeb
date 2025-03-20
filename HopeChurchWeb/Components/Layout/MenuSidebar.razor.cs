using Microsoft.AspNetCore.Components;

namespace HopeChurchWeb.Components.Layout;

public partial class MenuSidebar : ComponentBase
{
    [Parameter] public bool DrawerOpen { get; set; }
    [Parameter] public EventCallback<bool> DrawerOpenChanged { get; set; }

    private void DrawerToggle()
    {
        DrawerOpen = !DrawerOpen;
        DrawerOpenChanged.InvokeAsync(DrawerOpen);
    }
}