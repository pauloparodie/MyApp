using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Owin.Security;
using Microsoft.Owin;


namespace MyApp.Owin
{
    class OwinManager
    {
        public static void SignInUser(ClaimsIdentity userIdentity, IOwinContext ctx)
        {
            var authManager = ctx.Authentication;
            authManager.SignIn(new AuthenticationProperties(), userIdentity);
        }

        public static void SignOutUser(IOwinContext ctx)
        {
            var authManager = ctx.Authentication;
            authManager.SignOut();
        }
    }
}
