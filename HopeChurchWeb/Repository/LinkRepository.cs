using HopeChurchWeb.Data;
using HopeChurchWeb.Models;
using Serilog;

namespace HopeChurchWeb.Repository;

public class LinkRepository
{
    private readonly ChurchDBContext _context;

    public LinkRepository(ChurchDBContext context)
    {
        _context = context;
    }

    public List<LinksMain> SelectLinks()
    {
        try
        {
            var result = _context.LinksMains.ToList();
            return result;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: SelectLinks");
            return [];
        }
    }

    public List<FavoriteLink> SelectFavoriteLinks(int userId)
    {
        try
        {
            var result = _context.FavoriteLinks.Where(x => x.UserId == userId).ToList();
            return result;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: SelectLinks");
            return [];
        }
    }

    public bool InsertLink(LinksMain link)
    {
        try
        {
            _context.LinksMains.Add(link);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: InsertLink");
            return false;
        }
    }

    public bool InsertFavoriteLink(FavoriteLink favoriteLink)
    {
        try
        {
            _context.FavoriteLinks.Add(favoriteLink);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: InsertFavoriteLink");
            return false;
        }
    }

    public bool UpdateLink(int linkId, LinksMain link)
    {
        try
        {
            var data = _context.LinksMains.FirstOrDefault(x => x.Id == linkId);
            if (data == null) return false;

            data.Title = link.Title;
            data.Url = link.Url;
            data.Description = link.Description;

            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: UpdateLink");
            return false;
        }
    }

    public bool UpdateLinkClickCount(int linkId)
    {
        try
        {
            var data = _context.LinksMains.FirstOrDefault(x => x.Id == linkId);
            if (data == null) return false;

            data.ClickCount += 1;
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: UpdateLinkClickCount");
            return false;
        }
    }

    public bool DeleteLink(int linkId)
    {
        try
        {
            var data = _context.LinksMains.FirstOrDefault(x => x.Id == linkId);
            if (data == null) return false;

            _context.LinksMains.Remove(data);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: UpdateLink");
            return false;
        }
    }

    public bool DeleteFavoriteLink(FavoriteLink favoriteLink)
    {
        try
        {
            var data = _context.FavoriteLinks.FirstOrDefault(x =>
                x.LinkId == favoriteLink.LinkId && x.UserId == favoriteLink.UserId);
            if (data == null) return false;

            _context.FavoriteLinks.Remove(data);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: UpdateLink");
            return false;
        }
    }
}