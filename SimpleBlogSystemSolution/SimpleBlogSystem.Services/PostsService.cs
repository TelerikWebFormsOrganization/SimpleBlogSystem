namespace SimpleBlogSystem.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Common.Constants;
    using Data;
    using Models;

    public class PostsService : IPostsService
    {
        private readonly EfGenericRepository<Post> posts;
        private readonly EfGenericRepository<Category> categories;
        private readonly EfGenericRepository<User> users;

        public PostsService()
        {
            this.posts = new EfGenericRepository<Post>(new SimpleBlogSystemDbContext());
            this.categories = new EfGenericRepository<Category>(new SimpleBlogSystemDbContext());
            this.users = new EfGenericRepository<User>(new SimpleBlogSystemDbContext());
        }

        public int? Add(string title, string postContent, string creator, List<int> categoriesId)
        {

            var foundCategory = this.posts
                .All()
                .Where(p => p.Title == title)
                .FirstOrDefault();

            if (foundCategory != null)
            {
                return null;
            }

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

        public IQueryable<Post> GetById(int postId)
        {
            var result = this.posts
                .All()
                .Where(p => p.PostId == postId);

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

            this.posts.SaveChanges();
        }

        public void Remove(int postId)
        {
            var post = this.posts
                    .All()
                    .FirstOrDefault(p => p.PostId == postId);

            this.posts.Delete(post);
            this.posts.SaveChanges();
        }
    }
}
