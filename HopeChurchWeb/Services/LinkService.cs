using HopeChurchWeb.Models;
using HopeChurchWeb.Repository;

namespace HopeChurchWeb.Services;

public class LinkService
{
    private readonly LinkRepository _linkRepository;

    public LinkService(LinkRepository linkRepository)
    {
        _linkRepository = linkRepository;
    }

    public ServiceResponse UpdateLinkClickCount(int linkId)
    {
        var result = _linkRepository.UpdateLinkClickCount(linkId);
        return result switch
        {
            true => new ServiceResponse(true, string.Empty),
            false => new ServiceResponse(false, string.Empty)
        };
    }

    public ServiceResponse AddLink(FormLink formLink)
    {
        LinksMain link = new()
        {
            Title = formLink.Title,
            Url = formLink.Url,
            Description = formLink.Description
        };

        var result = _linkRepository.InsertLink(link);
        return result switch
        {
            true => new ServiceResponse(true, "新增成功"),
            false => new ServiceResponse(false, "新增失敗")
        };
    }

    public ServiceResponse SaveFavoriteLink(SaveLink saveLink)
    {
        FavoriteLink favoriteLink = new()
        {
            UserId = saveLink.UserId,
            LinkId = saveLink.LinkId
        };

        var result = saveLink.IsFavorite switch
        {
            true => _linkRepository.InsertFavoriteLink(favoriteLink),
            false => _linkRepository.DeleteFavoriteLink(favoriteLink)
        };

        return result switch
        {
            true => new ServiceResponse(true, string.Empty),
            false => new ServiceResponse(false, string.Empty)
        };
    }

    public ServiceResponse UpdateLink(int linkId, FormLink formLink)
    {
        LinksMain link = new()
        {
            Id = linkId,
            Title = formLink.Title,
            Url = formLink.Url,
            Description = formLink.Description
        };

        var result = _linkRepository.UpdateLink(linkId, link);
        return result switch
        {
            true => new ServiceResponse(true, "更新成功"),
            false => new ServiceResponse(false, "更新失敗")
        };
    }

    public List<LinksMain> GetLinks()
    {
        return _linkRepository.SelectLinks();
    }

    public List<FavoriteLink> GetFavoriteLinks(int userId)
    {
        return _linkRepository.SelectFavoriteLinks(userId);
    }

    public ServiceResponse RemoveLink(int linkId)
    {
        var result = _linkRepository.DeleteLink(linkId);
        return result switch
        {
            true => new ServiceResponse(true, "刪除成功"),
            false => new ServiceResponse(false, "刪除失敗")
        };
    }
}