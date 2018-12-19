using System.Web.Mvc;

namespace Demos.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Admin"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName + "_default",
                AreaName + "/{controller}/{action}",
                new { area = AreaName },
                new[] { GetType().Namespace + ".Controllers" });
        }
    }
}