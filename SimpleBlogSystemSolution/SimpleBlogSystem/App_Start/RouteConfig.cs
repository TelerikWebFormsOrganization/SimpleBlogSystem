namespace SimpleBlogSystem
{
    using System.Web.Routing;
    using Microsoft.AspNet.FriendlyUrls;

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Login",
            "login", "~/Account/Login.aspx");

            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
