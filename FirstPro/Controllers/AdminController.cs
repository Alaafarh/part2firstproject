using Microsoft.AspNetCore.Mvc;

namespace FirstPro.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
