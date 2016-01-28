namespace SimpleBlogSystem.Services
{
    using System.Linq;
    using Common.Constants;
    using Data;
    using Models;

    public class CommentsService : ICommentsService
    {

        private readonly EfGenericRepository<Post> posts;
        private readonly EfGenericRepository<Comment> comments;
        private readonly EfGenericRepository<User> users;

        public CommentsService()
        {
            this.posts = new EfGenericRepository<Post>(new SimpleBlogSystemDbContext());
            this.comments = new EfGenericRepository<Comment>(new SimpleBlogSystemDbContext());
            this.users = new EfGenericRepository<User>(new SimpleBlogSystemDbContext());
        }

        public int Add(string commentContent, string creator, int postId)
        {

            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == creator);

            var currentPost = this.posts
                .All()
                .FirstOrDefault(p => p.PostId == postId);

            var newComment = new Comment()
            {
                CommentContent = commentContent,
                User = currentUser,
                UserId = int.Parse(currentUser.Id),
                Post = currentPost,
                PostId = postId
            };

            this.comments.Add(newComment);
            this.comments.SaveChanges();

            return newComment.CommentId;
        }

        public IQueryable<Comment> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.comments
                .All()
                .OrderByDescending(c => c.DatePublished)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return result;
        }

        public void Update(int commentId, string commentContent)
        {
            var comment = this.comments
                .All()
                .FirstOrDefault(c => c.CommentId == commentId);
            
            if (commentContent != null)
            {
                comment.CommentContent = commentContent;
            }

            comments.SaveChanges();
        }

        public void Remove(int commentId)
        {
            var comment  = this.comments
                    .All()
                    .FirstOrDefault(c => c.CommentId == commentId);

            this.comments.Delete(comment);
            this.comments.SaveChanges();
        }
    }
}
