namespace SimpleBlogSystem.ConsoleApp
{
    using System.Linq;
    using Data;

    public class App
    {
        static void Main(string[] args)
        {
            SimpleBlogSystemDbContext data = new SimpleBlogSystemDbContext();
            data.Posts.Count();
        }
    }
}
