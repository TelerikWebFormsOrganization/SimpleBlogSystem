namespace SimpleBlogSystem.Services
{
    using System.Linq;
    using Common.Constants;
    using Models;

    public interface ICommentsService
    {
        IQueryable<Comment> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        int Add(string commentContent, string creator, int postId);

        void Update(int commentId, string commentContent);

        void Remove(int commentId);
    }
}
