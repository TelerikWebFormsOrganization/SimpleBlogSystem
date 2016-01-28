using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            var data = categories.All().ToList();

            this.ListViewCategories.DataSource = data;
            this.ListViewCategories.DataBind();
        }
    }
}