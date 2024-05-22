using RentCarApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCarApp.Mvc.Controllers
{
    public class LoginController : Controller
    {
        UserServices us = new UserServices();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModel log)
        {
            us.InsertUser(log);
            ViewBag.message = "Data Added successfully";
            return View();
        }
    }
}