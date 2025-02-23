using HopeChurchWeb.Models;
using HopeChurchWeb.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.RecommendedLinks;

public partial class RecommendedLinksPage : ComponentBase
{
    #region [Inject]

    [Inject] private IDialogService _dialogService { get; set; } = null!;

    [Inject] private IJSRuntime _jsRuntime { get; set; } = null!;

    [Inject] private LinkService _linkService { get; set; } = null!;

    [Inject] private ISnackbar _snackbar { get; set; } = null!;

    #endregion

    private string _searchText = string.Empty;
    private List<LinksMain> _links = [];
    private Dictionary<int, bool> _favoriteStates = new(); // 存儲收藏狀態的字典
    private Dictionary<int, bool> _linkCardExpandStates = new(); // 存儲展開狀態的字典

    private IEnumerable<LinksMain> _filteredLinks =>
        string.IsNullOrWhiteSpace(_searchText)
            ? _links
            : _links.Where(l => l.Title.Contains(_searchText, StringComparison.OrdinalIgnoreCase));

    protected override async Task OnInitializedAsync()
    {
        _links = _linkService.GetLinks();
        List<FavoriteLink> favoriteLinks = _linkService.GetFavoriteLinks(1);
        _favoriteStates = favoriteLinks.ToDictionary(x => x.LinkId, x => true);
        var favoriteLinkIds = favoriteLinks.Select(x => x.LinkId).ToHashSet();
        _links = _links.OrderByDescending(link => favoriteLinkIds.Contains(link.Id)).ToList();
    }

    #region [Link Event]

    private void HandleLinkClickCount(LinksMain link)
    {
        _linkService.UpdateLinkClickCount(link.Id);
    }

    private async Task HandleCopyToClipboardClick(string url)
    {
        await _jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", url);
        _snackbar.Add("已複製連結", Severity.Success);
    }

    private async Task HandleLinkEditClick(LinksMain link)
    {
        var dialogParameters = new DialogParameters { { "Link", link } };
        var dialog = await _dialogService.ShowAsync<LinkDialog>("編輯推薦連結",
            dialogParameters,
            new DialogOptions()
            {
                CloseOnEscapeKey = true,
                CloseButton = true
            });

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            var response = (ServiceResponse)result.Data!;
            _snackbar.Add(response.Message, response.Success ? Severity.Success : Severity.Error);
        }
    }

    private void HandleLinkDeleteClick(LinksMain link)
    {
        _linkService.RemoveLink(link.Id);
        _links = _linkService.GetLinks();
    }

    #endregion

    #region [Favorite Event]

    // 檢查是否已收藏
    private bool IsFavorite(int linkId)
    {
        return _favoriteStates.ContainsKey(linkId) && _favoriteStates[linkId];
    }

    // 切換收藏狀態
    private void HandleToggleFavoriteClick(int linkId)
    {
        if (!_favoriteStates.ContainsKey(linkId)) _favoriteStates[linkId] = false;

        _favoriteStates[linkId] = !_favoriteStates[linkId];

        // 這裡可以加入將收藏狀態保存到資料庫或 localStorage 的邏輯
        SaveFavoriteStateProcessing(linkId, _favoriteStates[linkId]);
    }

    // 儲存收藏狀態的方法
    private void SaveFavoriteStateProcessing(int linkId, bool state)
    {
        try
        {
            SaveLink saveLink = new()
            {
                UserId = 1, // 這裡可以改成從登入資訊取得
                LinkId = linkId,
                IsFavorite = state
            };

            var response = _linkService.SaveFavoriteLink(saveLink);
            _snackbar.Add(response.Message, response.Success ? Severity.Success : Severity.Error);
        }
        catch (Exception ex)
        {
            // 處理錯誤
            Console.WriteLine($"Error saving favorite state: {ex.Message}");
        }
    }

    #endregion

    #region [Expand Event]

    private bool GetExpandState(int linkId)
    {
        return _linkCardExpandStates.ContainsKey(linkId) && _linkCardExpandStates[linkId];
    }

    // 展開/收合說明的方法
    private void HandleToggleExpandClick(int linkId)
    {
        if (!_linkCardExpandStates.ContainsKey(linkId)) _linkCardExpandStates[linkId] = false;

        _linkCardExpandStates[linkId] = !_linkCardExpandStates[linkId];
    }

    #endregion

    private async Task HandleOpenAddLinkDialog()
    {
        var dialog = await _dialogService.ShowAsync<LinkDialog>("新增推薦連結",
            new DialogOptions()
            {
                CloseOnEscapeKey = true,
                CloseButton = true
            });

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            var response = (ServiceResponse)result.Data!;
            _snackbar.Add(response.Message, response.Success ? Severity.Success : Severity.Error);
        }
    }
}