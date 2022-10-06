using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Filters;


namespace MyApp.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class AdminOpController : Controller
    {
        [Route("Private")]
        [AdminAuthorization]
        public ActionResult Private()
        {
            return View();
        }

        [Route("Maria")]
        [Authorize(Users = "Maria")]
        public ActionResult Maria()
        {
            return View();
        }
    }


}