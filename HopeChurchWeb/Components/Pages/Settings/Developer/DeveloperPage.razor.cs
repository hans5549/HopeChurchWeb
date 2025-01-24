using HopeChurchWeb.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.Settings.Developer;

public partial class DeveloperPage : ComponentBase
{
    private void ItemUpdated(MudItemDropInfo<DropItem> dropItem)
    {
        dropItem.Item.Identifier = dropItem.DropzoneIdentifier;
    }

    private void AAItemUpdated(MudItemDropInfo<WebFunctionMain> dropItem)
    {
        dropItem.Item.ParentId = Convert.ToInt32(dropItem.DropzoneIdentifier);
    }

    private List<DropItem> _items = new()
    {
        new DropItem(){ Name = "Wallpapers", Identifier = "Folders" },
        new DropItem(){ Name = "Propaganda", Identifier = "Folders" },
        new DropItem(){ Name = "Funny, Dank, Meme", Identifier = "Folders" },
        new DropItem(){ Name = "Work", Identifier = "Folders" },
        new DropItem(){ Name = "Photos", Identifier = "Folders" },
        new DropItem(){ Name = "Untitled spreadsheet", Identifier = "Files" },
        new DropItem(){ Name = "LoseLips.txt", Identifier = "Files" },
        new DropItem(){ Name = "Untitled document", Identifier = "Files" },
        new DropItem(){ Name = "GoonSwarmBestSwarm.png", Identifier = "Files" },
        new DropItem(){ Name = "co2traitors.txt", Identifier = "Files" },
        new DropItem(){ Name = "import.csv", Identifier = "Files" },
        new DropItem(){ Name = "planned_components_2022-2023.txt", Identifier = "MudBlazor" },
    };

    private List<WebFunctionMain> _functionMains = new()
    {
        new WebFunctionMain() { Id = 1, Name = "後台", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 2, Name = "影音部", IsCategory = false, ParentId = 1 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 3, Name = "總務", IsCategory = false, ParentId = 1 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 4, Name = "管理者專區", IsCategory = false, ParentId = 1 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 5, Name = "其他", IsCategory = false, ParentId = 1 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 6, Name = "討論區", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 7, Name = "討論區", IsCategory = false, ParentId = 6 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 8, Name = "推薦連結", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 9, Name = "推薦連結", IsCategory = false, ParentId = 8 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 10, Name = "行事曆", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 11, Name = "行事曆", IsCategory = false, ParentId = 10 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 12, Name = "場地租借", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 13, Name = "場地租借", IsCategory = false, ParentId = 12 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 14, Name = "門禁管理", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 15, Name = "門禁管理", IsCategory = false, ParentId = 14 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 16, Name = "話語補聽", IsCategory = true, ParentId = 0 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 17, Name = "分類顯示", IsCategory = false, ParentId = 16 ,icon = "", url = "", IsActive = true },
        new WebFunctionMain() { Id = 18, Name = "月份顯示", IsCategory = false, ParentId = 16 ,icon = "", url = "", IsActive = true },
    };

    private List<WebFunctionMain> _parentNode = [];
    private List<WebFunctionMain> _childNode = [];

    protected async Task OnInitializedAsync()
    {
        await Task.CompletedTask;
        _parentNode = _functionMains.Where(function => function.ParentId == 0).ToList();
        _childNode = _functionMains.Where(function => function.ParentId != 0).ToList();
    }

    public class DropItem
    {
        public string Name { get; init; }
        public string Identifier { get; set; }
    }
}