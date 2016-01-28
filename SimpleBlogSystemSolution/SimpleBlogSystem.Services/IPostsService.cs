namespace SimpleBlogSystem.Services
{
    using Models;
    using Common.Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface IPostsService
    {
        IQueryable<Post> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        int Add(string title, string postContent, string creator, List<int> categories);

        void Update(int postId, string title, string postContent, List<int> addCategoryIds, List<int> removeCategoryIds);
    }
}
