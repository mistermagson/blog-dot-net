﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Filters
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            String usuario = filterContext.HttpContext.Session.GetString("usuario");
            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                new {
                    area = "",
                    controller = "Login",
                    action = "Index"
                }));
            }
        }
    }
}
