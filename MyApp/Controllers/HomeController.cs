using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //[Route("Home/Add/{val1?}/{val2?}")]
        public ActionResult Add(string id, string val1 = "10", string val2 = "5")
        {
            ViewBag.Val1 = val1;
            ViewBag.Val2 = val2;

            var req = Request;
            var ctx2 = HttpContext;

            ViewData["var1"] = "porto";

            var w = ViewBag.qw1;
            var e = ViewData["qw2"];
            var r = TempData["as"];

            ViewBag.o1 = new HttpCookie("teste");
            var r1 = ViewBag.o1;

            ViewData["o2"] = new HttpCookie("teste2");
            HttpCookie r2 = ViewData["o2"] as HttpCookie;

            ViewData["o6"] = new HttpCookie("teste5");
            var r6 = ViewData["o6"] as HttpCookie;

            TempData["o3"] = new HttpCookie("teste3");
            HttpCookie r3 = TempData["o3"] as HttpCookie;

           /*DBCodeFirst.ModelCFEntities ctx = new ModelCFEntities();
           List<Author> authors = ctx.Authors.ToList();
           List<Book> books = ctx.Books.ToList();*/

            //List<proc1_Result> res = db.proc1(4).ToList()<proc1_Result>();

            return View();
        }

        [Route("Home/Division")]
        public ActionResult Division()
        {
            string result = "OLEEE";



            return RedirectToAction("Multiply");
            //return Content("Paulo Jorge", "text");
        }

        [Route("Home/RedirectUrl")]
        public ActionResult RedirectUrl()
        {
            string result = "OLEEE";

            TempData["pol1"] = "yes";

            return RedirectToAction("Division", "Home");
        }

        [Route("Home/Multiply")]
        public ActionResult Multiply(string multparam)
        {
            string result = "OLEEE";

            TempData["pol1"] = "ola";

            return View("Multiplication");
        }

        [Route("Home/QueryValue/{value:int?}")]
        public ActionResult QueryValue(int value)
        {
            string result = "OLEEE";

            //string a = TempData["pol1"] as string;
            string a = TempData.Peek("pol1") as string;

            return Content("Paulo Jorge->" + (value + 1), "text");
        }
    }
}