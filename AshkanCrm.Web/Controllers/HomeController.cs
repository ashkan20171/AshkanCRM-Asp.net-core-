using Microsoft.AspNetCore.Mvc;

namespace AshkanCrm.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
