using System.Web.Mvc;

namespace Demos.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotExist()
        {
            return View();
        }
    }
}
