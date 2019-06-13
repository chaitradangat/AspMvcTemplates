using System.Web;
using System.Web.Mvc;
using AspMvcTemplates.Models;
using AspMvcTemplates.Application;

namespace AspMvcTemplates.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        //[Route("Validate/Login")]
        public ActionResult Validate()
        {
            ViewBag.Title = "Validate";

            return View();
        }

        [HttpPost]
        public ActionResult Validate(LoginViewModel loginModel)
        {
            if (Session["user"] is null)
            {
                CommonUtility utility = new CommonUtility();

                bool rememberuser = loginModel.RememberMe;

                string username = loginModel.UserName;

                string password = loginModel.Password;

                string userid = "";

                if (utility.ValidateLoginCredentials(username, password,ref userid))
                {
                    Session["user"] = userid;
                }
                else
                {
                    Session["user"] = null;
                }
            }

            return View(loginModel);
        }

    }
}