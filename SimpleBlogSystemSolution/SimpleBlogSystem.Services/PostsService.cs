namespace SimpleBlogSystem.Services
{
    using Models;
    using Common.Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;

    public class PostsService : IPostsService
    {
        private readonly IRepository<Post> posts;
        private readonly IRepository<User> users;

        public PostsService(IRepository<Post> postsRepo, IRepository<User> usersRepo)
        {
            this.posts = postsRepo;
            this.users = usersRepo;
        }

        public int Add(string name, string description, string creator, bool isPrivate = false)
        {

            //var currentUser = this.users
            //    .All()
            //    .FirstOrDefault(u => u.UserName == creator);

            //var newProject = new SoftwareProjectOLD()
            //{
            //    Name = name,
            //    Description = description,
            //    Private = isPrivate,
            //    CreatedOn = DateTime.Now
            //};

            //newProject.Users.Add(currentUser);

            //this.projects.Add(newProject);
            //this.projects.SaveChanges();

            //return newProject.Id;
            return 0;
        }

        public IQueryable<Post> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.posts
                .All()
                .OrderByDescending(p => p.PostDatePublished)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return result;
        }
    }
}
