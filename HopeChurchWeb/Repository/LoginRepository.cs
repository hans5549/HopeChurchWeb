using HopeChurchWeb.Data;
using HopeChurchWeb.Models;
using Serilog;

namespace HopeChurchWeb.Repository;

public class LoginRepository
{
    public LoginRepository()
    {
    }

    public List<UserMain> SelectUserMains()
    {
        try
        {
            FakeData fakeData = new();
            return fakeData.GetUserList();
        }
        catch (Exception e)
        {
            Log.Error(e, "Repository: LoginRepository, Function: SelectUserMains");
            return [];
        }
    }
}