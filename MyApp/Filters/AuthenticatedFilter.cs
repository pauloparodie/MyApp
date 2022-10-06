using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Filters;
using System.Web.Mvc;


namespace MyApp.Filters
{
    public class AuthenticatedFilter : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext ctx)
        {
            if (!ctx.HttpContext.User.Identity.IsAuthenticated)
            {
                ctx.Result = new HttpUnauthorizedResult("Not logged in");
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext ctx)
        {

        }
    }
}
