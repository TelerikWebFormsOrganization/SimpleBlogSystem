namespace SimpleBlogSystem.ConsoleApp
{
    using System;
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
        }
    }
}
