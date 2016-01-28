using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleBlogSystem.Services;

namespace SimpleBlogSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PostsService posts = new PostsService();

            var postsData = posts.All().ToList();
            this.ListViewPosts.DataSource = postsData;
            this.ListViewPosts.DataBind();
        }
    }
}