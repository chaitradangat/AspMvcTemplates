﻿using System.Web;
using System.Web.Mvc;
using AspMvcTemplates.Models;


namespace AspMvcTemplates.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Validate()
        {
            ViewBag.Title = "Validate";

            return View();
        }

        [HttpPost]
        public ActionResult Validate(LoginViewModel loginModel)
        {
            var username = loginModel.UserName;

            var password = loginModel.Password;

            var rememberuser = loginModel.RememberMe;

            return View(loginModel);
        }

    }
}