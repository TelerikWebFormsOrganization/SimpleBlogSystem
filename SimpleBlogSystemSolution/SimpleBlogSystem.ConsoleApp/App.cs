namespace SimpleBlogSystem.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Models;
    public class App
    {
        static void Main(string[] args)
        {
            SimpleBlogSystemDbContext data = new SimpleBlogSystemDbContext();
            data.Posts.Count();

            Seed(data);
        }

        private static void Seed(SimpleBlogSystemDbContext data)
        {
            List<Category> categories = new List<Category>();

            for (int i = 0; i < 5; i++)
            {
                data.Categories.Add(new Category()
                {
                    CategoryName = "category" + (i + 1)
                });
            }

            for (int i = 0; i < 10; i++)
            {
                data.Posts.Add(new Post()
                {
                    PostContent = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    UserId = i % 3
                });
            }

            for (int i = 0; i < 5; i++)
            {
                data.Comments.Add(new Comment()
                {
                    CommentContent = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb",
                    UserId = i % 2
                });
            }
        }
    }
}
