using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Filters;
using System.Web.Mvc;


namespace MyApp.Filters
{
    public class ErrorFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext ctx)
        {
            //Log Error
        }
    }
}
