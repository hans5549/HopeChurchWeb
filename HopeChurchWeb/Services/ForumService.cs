using HopeChurchWeb.Models;
using HopeChurchWeb.Repository;

namespace HopeChurchWeb.Services;

public class ForumService
{
    private readonly ForumRepository  _repository;

    public ForumService(ForumRepository  repository)
    {
        _repository = repository;
    }

    public List<ForumArticleCategory> SelectAllForumArticleCategory()
    {
        return _repository.SelectAllForumArticleCategory();
    }
}