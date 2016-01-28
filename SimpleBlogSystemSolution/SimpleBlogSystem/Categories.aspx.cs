using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using SimpleBlogSystem.Services;

namespace SimpleBlogSystem
{
    public partial class Categories : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            CategoriesService categories = new CategoriesService();
            var categoriesData = categories.All().ToList();

            this.ListViewCategories.DataSource = categoriesData;
            this.ListViewCategories.DataBind();
        }

        protected void CategoryLink_Click(object sender, EventArgs e)
        {
            string categoryName = ((LinkButton)sender).Text;

            PostsService posts = new PostsService();
            var postsData = posts.All()
                .Where(p => p.Categories.Any(c => c.CategoryName == categoryName))
                .ToList();

            this.ListViewPosts.DataSource = postsData;
            this.ListViewPosts.DataBind();
        }
    }
}