using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //so chama o metodo com get
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //sobrecarga
        [HttpPost] //so chama o metodo com post
        public ActionResult Login([FromForm] Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                if (usuario.Email == "pedropestka@gmail.com" && usuario.Senha == "123456")
                {
                    //Add Session
                    //HttpContext.Session.SetString("Login", "true");
                    //HttpContext.Session.SetInt32("UserID", 32);

                    //Ler Session
                    //string login = HttpContext.Session.GetString("Login");

                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}