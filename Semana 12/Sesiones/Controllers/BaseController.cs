using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sesiones.Controllers
{
    public class BaseController : Controller
    {

        public override void OnActionExecuting(ActionExecutingContext context)   
        {
            var usuario = HttpContext.Session.GetString("usuario");  

            ViewData["usuario"] = usuario;
        }
    }
}