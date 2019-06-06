using System.Web;
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
        public ActionResult Validate(LoginModel loginModel)
        {
            var username = loginModel.UserName;

            var password = loginModel.Password;

            return View(loginModel);
        }

    }
}