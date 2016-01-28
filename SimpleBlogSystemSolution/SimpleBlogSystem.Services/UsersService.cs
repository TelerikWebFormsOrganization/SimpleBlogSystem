namespace SimpleBlogSystem.Services
{
    using System;
    using System.Linq;
    using Common.Constants;
    using Data;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class UsersService : IUsersService
    {
        private readonly EfGenericRepository<User> users = new EfGenericRepository<User>(new SimpleBlogSystemDbContext());
        
        public IQueryable<User> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.users
                .All()
                .OrderByDescending(u => u.UserName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return result;
        }

        public IQueryable<User> GetById(int userId)
        {
            var result = this.users
                .All()
                .Where(u => int.Parse(u.Id) == userId);

            return result;
        }

        public void Update(string userId, string email, string username)
        {
            var user = this.users
                .All()
                .FirstOrDefault(u => u.Id == userId);
            
            if (email != null)
            {
                user.Email = email;
            }

            if (username != null)
            {
                user.UserName = username;
            }

            users.SaveChanges();
        }

        public void Remove(int userId)
        {
            var user  = this.users
                    .All()
                    .FirstOrDefault(u => int.Parse(u.Id) == userId);

            this.users.Delete(user);
            this.users.SaveChanges();
        }

        public int Register()
        {
            return 0;
        }
    }
}
