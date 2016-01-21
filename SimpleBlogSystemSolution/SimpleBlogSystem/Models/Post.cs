using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlogSystem.Models
{
    public class Post
    {
        public Post()
        {

        }

        public int PostId { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDatePublished { get; set; }
        public DateTime PostLastModified { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Category> Categories { get; set;}
    }
}