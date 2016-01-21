using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlogSystem.Models
{
    public class Comment
    {
        public Comment()
        {

        }

        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime DatePublished { get; set; }

        public ApplicationUser User { get; set; }

    }
}