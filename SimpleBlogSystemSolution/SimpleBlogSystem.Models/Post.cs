﻿namespace SimpleBlogSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Post
    {
        private ICollection<Comment> comments;
        private ICollection<Category> categories;

        public Post()
        {
            this.PostDatePublished = DateTime.Now;
            this.comments = new HashSet<Comment>();
            this.categories = new HashSet<Category>();
        }

        public int PostId { get; set; }

        [Required]
        [MinLength(200)]
        [MaxLength(5000)]
        public string PostContent { get; set; }

        public DateTime PostDatePublished { get; set; }

        public DateTime PostLastModified { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public virtual ICollection<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }
    }
}