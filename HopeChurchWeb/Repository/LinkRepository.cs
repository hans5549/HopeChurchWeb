using HopeChurchWeb.Data;
using HopeChurchWeb.Models;
using Serilog;

namespace HopeChurchWeb.Repository;

public class LinkRepository
{
    public LinkRepository()
    {

    }

    public List<LinksMain> SelectLinks()
    {
        try
        {
            FakeData fakeData = new();
            return fakeData.GetLinksList();
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LinkRepository, Function: SelectLinks");
            return [];
        }
    }
}