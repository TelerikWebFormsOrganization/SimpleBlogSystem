namespace SimpleBlogSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public Comment()
        {
            this.DatePublished = DateTime.Now;
        }

        public int CommentId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string CommentContent { get; set; }

        public DateTime DatePublished { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}