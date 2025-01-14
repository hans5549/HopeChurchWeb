using HopeChurchWeb.Common.Enum;
using HopeChurchWeb.Models;
using HopeChurchWeb.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.RecommendedLinks;

public partial class LinkDialog : ComponentBase
{
    [CascadingParameter]
    private IMudDialogInstance MudDialog { get; set; } = null!;

    [Inject]
    private IDialogService _dialogService { get; set; } = null!;

    [Inject]
    private LinkService _linkService { get; set; } = null!;

    [Parameter]
    public LinksMain Link { get; set; } = new();

    private ActionEnum _action;
    private string _dialogTitle = string.Empty;
    private MudForm _form = new();
    private FormLink _formLink = new();

    protected override async Task OnInitializedAsync()
    {
        _action = Link.Id == 0 ? ActionEnum.Create : ActionEnum.Update;
        _dialogTitle = _action == ActionEnum.Update ? "編輯推薦連結" : "新增推薦連結";
        if (_action == ActionEnum.Update)
        {
            _formLink.Title = Link.Title;
            _formLink.Url = Link.Url;
            _formLink.Description = Link.Description;
        }
    }

    private IEnumerable<string> ValidateUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            yield return "請輸入連結網址";
        }
        else if (!Uri.TryCreate(url, UriKind.Absolute, out _))
        {
            yield return "請輸入有效的網址";
        }
    }

    private void Submit()
    {
        ServiceResponse response = _action switch
        {
            ActionEnum.Create => _linkService.AddLink(_formLink),
            ActionEnum.Update => _linkService.UpdateLink(Link.Id, _formLink),
            _ => throw new ArgumentOutOfRangeException()
        };

        MudDialog.Close(DialogResult.Ok(response));
    }

    private void Cancel()
    {
        MudDialog.Cancel();
    }
}