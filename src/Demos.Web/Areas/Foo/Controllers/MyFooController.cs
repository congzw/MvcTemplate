using System.Web.Mvc;

namespace Demos.Web.Areas.Foo.Controllers
{
    public class MyFooController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}