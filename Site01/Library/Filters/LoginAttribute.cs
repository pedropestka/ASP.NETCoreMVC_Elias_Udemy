﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // verificar se a seção existe
            if (context.HttpContext.Session.GetString("Login") == null)
            {
                // redirecionar
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }




        }
    }
}
