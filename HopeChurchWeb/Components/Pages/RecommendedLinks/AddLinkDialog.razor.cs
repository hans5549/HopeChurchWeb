using HopeChurchWeb.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.RecommendedLinks;

public partial class AddLinkDialog : ComponentBase
{
    [CascadingParameter]
    private IMudDialogInstance MudDialog { get; set; } = null!;

    [Inject]
    private IDialogService _dialogService { get; set; } = null!;

    private MudForm _form = new();
    private FormAddLink _formAddLink = new();

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

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    private void Submit()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }
}