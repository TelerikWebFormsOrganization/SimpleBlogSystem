namespace SimpleBlogSystem.Services
{
    using Models;
    using Common.Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface ICategoriesService
    {
        IQueryable<Category> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        int Add(string name);
    }
}
