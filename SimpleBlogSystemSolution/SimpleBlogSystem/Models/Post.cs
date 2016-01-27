namespace SimpleBlogSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Post
    {
        public Post()
        {

        }

        public int PostId { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDatePublished { get; set; }
        public DateTime PostLastModified { get; set; }

        public int ApplicationUserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Category> Categories { get; set;}
    }
}