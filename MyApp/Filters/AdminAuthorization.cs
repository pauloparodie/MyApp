using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Filters;
using System.Web.Mvc;


namespace MyApp.Filters
{
    class AdminAuthorization : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext ctx)
        {
            if (!ctx.HttpContext.User.IsInRole("Admin"))
            {
                ctx.Result = new HttpUnauthorizedResult("Not Admin");
            }
        }
    }
}
