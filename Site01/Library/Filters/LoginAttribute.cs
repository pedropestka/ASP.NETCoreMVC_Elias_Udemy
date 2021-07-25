using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // verificar se a seção existe
            if (context.HttpContext.Session.GetString("Login") == null)
            {
                //TempData
                if (context.Controller != null)
                {
                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "Faça login para acessar a página";
                }
                                
                // redirecionar
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }
}
