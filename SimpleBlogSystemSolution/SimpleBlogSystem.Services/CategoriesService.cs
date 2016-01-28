namespace SimpleBlogSystem.Services
{
    using System.Linq;
    using Common.Constants;
    using Data;
    using Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> categories;

        public CategoriesService(IRepository<Category> categoriesRepo)
        {
            this.categories = categoriesRepo;
        }

        public int Add(string name)
        {
            var newCategory = new Category()
            {
                CategoryName = name
            };

            this.categories.Add(newCategory);
            this.categories.SaveChanges();

            return newCategory.CategoryId;
        }

        public IQueryable<Category> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.categories
                .All()
                .OrderByDescending(c => c.CategoryName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return result;
        }
    }
}
