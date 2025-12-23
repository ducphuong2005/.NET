using KTHP_De2Emp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTHP_De2Emp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user=db.Accouts.SingleOrDefault(acc=>acc.username==username && acc.password==password);
            if(user == null)
            {
                ViewBag.msg = "Sai tên đăng nhập hoặc mật khẩu";
                return View();
            }
            else
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Management");
            }

        }
        public ActionResult Logout ()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Management");
        }
    }
}