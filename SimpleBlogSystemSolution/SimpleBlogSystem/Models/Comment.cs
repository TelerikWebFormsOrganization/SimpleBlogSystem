namespace SimpleBlogSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public Comment()
        {

        }

        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime DatePublished { get; set; }

        public int ApplicationUserId { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}