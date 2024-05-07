//using FirstPro.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace FirstPro.Controllers
//{
//    public class CustmerController : Controller
//    {
//        private readonly ModelContext _context;
//        private readonly IWebHostEnvironment _webHostEnvironment;
//        public CustmerController(ModelContext context, IWebHostEnvironment webHostEnvironment)
//        {

//            _context = context;
//            _webHostEnvironment = webHostEnvironment;
//        }
//        public IActionResult CustmerProfile()
//        {
//            var id = HttpContext.Session.GetInt32("IDcustmer");
//            var Login = _context.Userlogins.Include(obj => obj.Userid).Where(obj => obj.UserloginId == id).FirstOrDefault();
//            var user = _context.Users.Where(obj => obj.UserId == Login.Userid).FirstOrDefault();

//            var tuple = new Tuple<Userlogin, User>(Login, user);
//            return View(tuple);
//        }
//        [HttpPost]
//        public IActionResult CustmerProfile(string UserName, string Fname, string Lname, string Email, string NewPass, string ConfirmPass)
//        {
//            var id = HttpContext.Session.GetInt32("IDcustmer");
//            var Login = _context.Userlogins.Include(obj => obj.Userid).Where(obj => obj.UserloginId == id).FirstOrDefault();
//            var user = _context.Users.Where(obj => obj.UserId == Login.Userid).FirstOrDefault();

//            var tuple = new Tuple<Userlogin, User>(Login, user);
//            if (UserName == null && Fname == null && Lname == null && Email == null && NewPass == null)
//            {
//                //_toastNotification.Warning("Please Fill All Required Input");
//            }
//            else
//            {
//                if (UserName != null)
//                {
//                    Login.Username = UserName;
//                }
//                if (Fname != null)
//                {
//                    user.Fname = Fname;
//                }
//                if (Lname != null)
//                {
//                    user.Lname = Lname;
//                }
//                if (Email != null)
//                {
//                    user.Email = Email;
//                }
//                if (NewPass != null)
//                {

//                    if (NewPass.Equals(ConfirmPass))
//                    {
//                        Login.Password = NewPass;
//                    }

//                }


//                //else
//                //{
//                //    //_toastNotification.Warning("The password does not match");
//                //    return View(tuple);
//                //}






//                _context.Update(Login);
//                _context.SaveChanges();
//                _context.Update(user);
//                _context.SaveChanges();
//                //_toastNotification.Success("Your Profile Updated Successfully");

//            }
//            return View(tuple);
//        }
//    }
//}
