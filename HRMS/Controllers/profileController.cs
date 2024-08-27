using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class profileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult profile()
        {
            return View();
        }
    }
}
