using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ESIForm()
        {
            return View();
        }
    }
}
