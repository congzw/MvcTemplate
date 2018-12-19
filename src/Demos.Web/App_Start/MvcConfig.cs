using System.Web.Mvc;
using System.Web.Routing;
using Demos.Common.Themes;

namespace Demos.Web
{
    public class MvcConfig
    {
        public static void Init()
        {
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            RegisterViewEngines(ViewEngines.Engines);
        }

        private static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            var defaultNamespace = typeof (MvcConfig).Namespace + ".Controllers";
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { defaultNamespace }
            );

            routes.MapRoute(
                name: "Root_Default",
                url: "",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { defaultNamespace }
            );
        }


        private static void RegisterViewEngines(ViewEngineCollection engines)
        {
            //WebViewPageConfig.CdnEnabled = false;
            //WebViewPageConfig.ThemeEnabled = true;
            //ThemeLogger.Enabled = true;

            //replace
            engines.Clear();
            engines.Add(new ThemeableRazorViewEngine());
            //not replace
            //engines.Insert(0, new ThemeableRazorViewEngine());
        }
    }
}
