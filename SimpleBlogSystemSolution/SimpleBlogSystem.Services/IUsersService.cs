namespace SimpleBlogSystem.Services
{
    using System.Linq;
    using Common.Constants;
    using Models;

    public interface IUsersService
    {
        IQueryable<User> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        IQueryable<User> GetById(int userId);

        void Update(string userId, string email, string username);

        void Remove(int userId);
    }
}
