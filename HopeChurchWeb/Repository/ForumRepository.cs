using HopeChurchWeb.Data;
using HopeChurchWeb.Models;
using Serilog;

namespace HopeChurchWeb.Repository;

public class ForumRepository
{
    private readonly ChurchDBContext _context;

    public ForumRepository(ChurchDBContext context)
    {
        _context = context;
    }

    public List<ForumArticleCategory> SelectAllForumArticleCategory()
    {
        try
        {
            var result = _context.ForumArticleCategories
                .Where(c => c.IsVisible == true)
                .ToList();

            return result;
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: ForumRepository, Function: SelectAllForumArticleCategory");
            throw;
        }
    }
}