using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
