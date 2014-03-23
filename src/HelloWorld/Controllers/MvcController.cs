using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class MvcController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}