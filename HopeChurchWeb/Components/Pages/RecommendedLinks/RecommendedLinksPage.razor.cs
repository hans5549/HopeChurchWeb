using HopeChurchWeb.Models;
using HopeChurchWeb.Services;
using Microsoft.AspNetCore.Components;

namespace HopeChurchWeb.Components.Pages.RecommendedLinks;

public partial class RecommendedLinksPage : ComponentBase
{
    #region [Inject]

    [Inject]
    private LinkService LinkService { get; set; } = null!;

    #endregion


    private List<LinksMain> _links = new();

    protected override async Task OnInitializedAsync()
    {
        _links = LinkService.GetLinks();
    }
}