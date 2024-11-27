using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages;

public partial class Index : ComponentBase
{
    private MudCarousel<string> _carousel = null!;
    private int _selectedIndex = 0;
    private IList<string> _source = new List<string>() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
}