namespace SimpleBlogSystem.Services
{
    using System.Linq;
    using Common.Constants;
    using Models;


    public interface ICategoriesService
    {
        IQueryable<Category> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        int? Add(string name);
    }
}
