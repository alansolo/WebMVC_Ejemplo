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

        [HttpPost]
        public JsonResult ValidarLogin(string usuario, string password)
        {
            string mensaje = "";

            try
            {
                //TENDRIA QUE IR A LA BASE O ALGUN SERVICIO A COMPARAR EL USUARIO

                if (usuario == "alberto" && password == "alberto123")
                {
                    mensaje = "OK";
                }
                else
                {
                    mensaje = "El usuario y/o password es incorrecto.";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }

            return Json(mensaje, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetEmpleado()
        {
            Datos.LoginDAT.EmpleadoDAT empleado = new Datos.LoginDAT.EmpleadoDAT();

            List<Datos.Empleado> listaEmpleado = empleado.GetEmpleado("14141414");
            
            List<EmpleadoModelo> listaEmpleadoModelo = listaEmpleado.
                Select(x => new EmpleadoModelo
                {
                    numEmpleado = x.numEmpleado,
                    nombre = x.nombre,
                    apellidoP = x.apellidoP,
                    apellidoM = x.apellidoM
                }).ToList();

            return Json(listaEmpleadoModelo, JsonRequestBehavior.AllowGet);
        }
    }
}