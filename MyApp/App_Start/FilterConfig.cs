using System.Web;
using System.Web.Mvc;
using MyApp.Filters;
using System;


namespace MyApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute() { ExceptionType = typeof(Exception), View = "FilterError" });
            filters.Add(new ErrorFilter());
           
        }
    }
}
