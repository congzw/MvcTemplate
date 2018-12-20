using System.Web.Mvc;

namespace Demos.Web.Areas.Foo
{
    public class FooAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Foo"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_IndexFoo",
                "Admin/Home/Index2",
                new { area = "Admin", Controller = "Home", Action = "Index2" },
                new[] { GetType().Namespace + ".Controllers" });
            
            context.MapRoute(
                AreaName + "_default",
                AreaName + "/{controller}/{action}",
                new { area = AreaName },
                new[] { GetType().Namespace + ".Controllers" });
        }
    }
}