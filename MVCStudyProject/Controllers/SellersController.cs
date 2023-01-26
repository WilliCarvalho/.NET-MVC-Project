using Microsoft.AspNetCore.Mvc;

namespace MVCStudyProject.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
