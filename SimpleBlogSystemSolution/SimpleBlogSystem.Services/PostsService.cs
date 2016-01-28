namespace SimpleBlogSystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common.Constants;
    using Data;
    using Models;

    public class PostsService : IPostsService
    {
        private readonly IRepository<Post> posts;
        private readonly IRepository<Category> categories;
        private readonly IRepository<User> users;

        public PostsService(IRepository<Post> postsRepo, IRepository<Category> categoriesRepo, IRepository<User> usersRepo)
        {
            this.posts = postsRepo;
            this.categories = categoriesRepo;
            this.users = usersRepo;
        }

        public int Add(string title, string postContent, string creator, List<int> categoriesId)
        {

            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == creator);

            var newPost = new Post()
            {
                Title = title,
                PostContent = postContent,
                User = currentUser,
                UserId = int.Parse(currentUser.Id)
            };

            foreach (int categoryId in categoriesId)
            {
                var currentCategory = this.categories
                    .All()
                    .FirstOrDefault(c => c.CategoryId == categoryId);

                newPost.Categories.Add(currentCategory);
            }

            this.posts.Add(newPost);
            this.posts.SaveChanges();

            return newPost.PostId;
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

        public void Update(int postId, string title, string postContent, List<int> addCategoryIds, List<int> removeCategoryIds)
        {
            var post = this.posts
                .All()
                .FirstOrDefault(p => p.PostId == postId);

            if (title != null)
            {
                post.Title = title;
            }

            if (postContent != null)
            {
                post.PostContent = postContent;
            }

            foreach (int categoryId in removeCategoryIds)
            {
                var category = this.categories
                    .All()
                    .FirstOrDefault(c => c.CategoryId == categoryId);

                if (post.Categories.Contains(category))
                {
                    post.Categories.Remove(category);
                }
            }

            foreach (int categoryId in addCategoryIds)
            {
                var category = this.categories
                    .All()
                    .FirstOrDefault(c => c.CategoryId == categoryId);
                
                    post.Categories.Add(category);
            }

            posts.SaveChanges();
        }
    }
}
