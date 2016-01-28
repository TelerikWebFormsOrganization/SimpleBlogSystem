using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleBlogSystem.Services;

namespace SimpleBlogSystem.Posts
{
    public partial class NewPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriesService catService = new CategoriesService();
            CategorySelect.DataSource = catService.All().Select(x=> x.CategoryName).ToList();
            CategorySelect.DataBind();
            Page.DataBind();
        }
    }
}