namespace SimpleBlogSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
