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

    public List<LinksMain> GetLinks()
    {
        return _linkRepository.SelectLinks();
    }
}