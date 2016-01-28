namespace SimpleBlogSystem.Services
{
    using System.Linq;
    using Common.Constants;
    using Data;
    using Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly EfGenericRepository<Category> categories;

        public CategoriesService()
        {
            this.categories = new EfGenericRepository<Category>(new SimpleBlogSystemDbContext());
        }

        public int? Add(string name)
        {
            var foundCategory = this.categories
                .All()
                .Where(c => c.CategoryName == name)
                .FirstOrDefault();

            if (foundCategory != null)
            {
                return null;
            }

            var newCategory = new Category()
            {
                CategoryName = name
            };

            this.categories.
                Add(newCategory);
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
