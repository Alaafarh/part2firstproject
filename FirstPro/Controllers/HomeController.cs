using FirstPro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModelContext _context;

        public HomeController(ILogger<HomeController> logger, ModelContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //ViewBag.UserId = HttpContext.Session.GetString("UserId");
            //ViewBag.Roleid = HttpContext.Session.GetString("Roleid");

            var user = _context.Userlogins.Where(obj => obj.Userid == HttpContext.Session.GetInt32("AdminId")).FirstOrDefault();
            if (user != null)
                ViewBag.IDAdmin = user.Roleid;
            var user2 = _context.Userlogins.Where(obj => obj.Userid == HttpContext.Session.GetInt32("IDcustmer")).FirstOrDefault();
            if (user2 != null)
                ViewBag.IDcustmer = user2.Roleid;
            var user3 = _context.Userlogins.Where(obj => obj.Userid == HttpContext.Session.GetInt32("Chifid")).FirstOrDefault();
            if (user3 != null)
                ViewBag.Chifid = user3.Roleid;
            //if (user2 != null)
            //{
            //    if (user2.Roleid == 2)
            //    {
            //        ViewBag.IDchif = user2.Roleid;
            //    }
            //    else if (user2.Roleid == 3)
            //    {
            //        ViewBag.IDcustmer = user2.Roleid;

            //    }
            //}

            return View();
        }
        //switch (user2.Roleid)
        //{

        //    case 2:
        //        ViewBag.IDchif = user2.Roleid;
        //        break;
        //    case 3:
        //        ViewBag.IDcustmer = user2.Roleid;
        //        break;


        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}