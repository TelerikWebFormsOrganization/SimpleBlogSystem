namespace SimpleBlogSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class SimpleBlogSystemDbContext : IdentityDbContext<User>, ISimpleBlogSystemDbContext
    {
        public SimpleBlogSystemDbContext()
            : base("SimpleBlogSystemDb", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public static SimpleBlogSystemDbContext Create()
        {
            return new SimpleBlogSystemDbContext();
        }
    }
}
