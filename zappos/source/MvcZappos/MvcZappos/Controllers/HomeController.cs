using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZappos.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData(string product_code)
        {
            var url = "http://api.zappos.com/Product?key=52ddafbe3ee659bad97fcce7c53592916a6bfd73&includes=[\"styles\"]&id=" + product_code;
            var str = Util.GetWebStream(url);
            return Content("[" + str + "]");
        }
    }
}
