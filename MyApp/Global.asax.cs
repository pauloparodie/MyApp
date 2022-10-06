using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.Cookies;
using System.Web.Helpers;
using MyApp.IdentityProvider;
using System.Threading.Tasks;


namespace MyApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperHelper.ConfigureMappings();

            using (IdentityManager _identityManager = new IdentityManager())
            {
                Task.WaitAll(_identityManager.creatInitialUsersRolesAsync());
            }                
        }

        protected void Application_Error()
        {
            Exception ex = Server.GetLastError();
            var appDirForLog = HttpContext.Current.Request.PhysicalApplicationPath;
            //Log Error
            Response.Redirect("/Error500.html");
        }
    }
}
