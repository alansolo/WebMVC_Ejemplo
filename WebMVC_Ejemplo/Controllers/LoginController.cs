using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_Ejemplo.Models.Login;

namespace WebMVC_Ejemplo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        //GET
        [HttpGet]
        public JsonResult EjemploGet()
        {
            LoginModelo login = new LoginModelo();

            login.usuario = "alan";
            login.password = "alan1234";


            System.Threading.Thread.Sleep(3000);

            return Json(login, JsonRequestBehavior.AllowGet);
        }
    }
}