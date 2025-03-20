using HopeChurchWeb.Models;
using HopeChurchWeb.Services;
using Microsoft.AspNetCore.Components;

namespace HopeChurchWeb.Components.Pages.Forum;

public partial class ForumPage : ComponentBase
{
    [Inject] private ForumService ForumService { get; set; } = null!;

    private Dictionary<int, List<ForumArticleCategory>> _categoryMap = [];

    protected override async Task OnInitializedAsync()
    {
        InitializeSideCategory();

        await base.OnInitializedAsync();
    }

    private void InitializeSideCategory()
    {
        List<ForumArticleCategory> categories = ForumService.SelectAllForumArticleCategory();
        foreach (var category in categories)
        {
            if (category.ParentId == 0)
            {
                _categoryMap.TryAdd(category.Id, [category]);
            }
            else
            {
                _categoryMap[category.ParentId].Add(category);
            }
        }
    }
}