namespace SimpleBlogSystem.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Services;

    public class App
    {
        static void Main(string[] args)
        {
            Seed();
        }

        private static void Seed()
        {
            CategoriesService categories = new CategoriesService();

            categories.Add("Programming");
            categories.Add("CSharp");
            categories.Add("JavaScript");
            categories.Add("Hobbies");

            var all = categories.All().ToList();

            foreach (var cat in all)
            {

                Console.WriteLine(cat.CategoryName);
            }

            PostsService posts = new PostsService();

<<<<<<< HEAD
            posts.Add("Exam",
                "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32.",
                "spurch@spurch.com",
=======
            posts.Add("Zopfli Optimization: Literally Free Bandwidth",
                "In 2007 I wrote about using PNGout to produce amazingly small PNG images. I still refer to this topic frequently, as seven years later, the average PNG I encounter on the Internet is very unlikely to be optimized. ",
                "john@john.com",
>>>>>>> refs/remotes/origin/master
                new List<int>() { 1 });

            posts.Add("The Hugging Will Continue Until Morale Improves",
                "I saw in today's news that Apple open sourced their Swift language. One of the most influential companies in the world explicitly adopting an open source model – that's great! I'm a believer. One of the big reasons we founded Discourse was to build an open source solution that anyone, anywhere could use and safely build upon.",
                "john@john.com",
                new List<int>() { 1 });

            posts.Add("The 2016 HTPC Build",
                "I saw in today's news that Apple open sourced their Swift language. One of the most influential companies in the world explicitly adopting an open source model – that's great! I'm a believer. One of the big reasons we founded Discourse was to build an open source solution that anyone, anywhere could use and safely build upon.",
                "john@john.com",
                new List<int>() { 1 });
            posts.Add("10 Years of CodeMash",
                @"I spent this past week at the 10th annual CodeMash conference in Sandusky OH. Every single event has been enjoyable, envigorating, and a great way to kick-start the year.

The event has changed dramatically over the past decade, but it still has the same core values from when it was started. It’s a group of people passionate about technology in many incarnations, and willing to share and learn from each other. Looking back at 10 years of CodeMash, several larger trends appear.

Early on, the languages discussed most were Java, C#, VB.NET, and Python. Over time, more and more interest in Ruby grew. Java waned for a time. Functional languages like F#, Haskell, and Erlang became more popular. There were a few Scala sessions.",
                "john@john.com",
                new List<int>() { 2 });
            posts.Add("Milk + Soap + Food Coloring = Awesome Reaction",
                @" Food coloring will allow you to see what is actually happening and create beautiful swirls and patterns. Any kind, color or amount will work. Have fun experimenting!
To hold the milk, use a shallow bowl or a plate with raised edges.
Regular old dish soap is the way to go.
Finally some Q-tips to apply the soap with.",
                "john@john.com",
                new List<int>() { 4 });

        }
    }
}
