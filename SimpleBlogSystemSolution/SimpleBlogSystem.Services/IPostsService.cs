namespace SimpleBlogSystem.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Common.Constants;
    using Models;


    public interface IPostsService
    {
        IQueryable<Post> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        IQueryable<Post> GetById(int postId);

        int? Add(string title, string postContent, string creator, List<int> categories);

        void Update(int postId, string title, string postContent, List<int> addCategoryIds, List<int> removeCategoryIds);

        void Remove(int postId);
    }
}
