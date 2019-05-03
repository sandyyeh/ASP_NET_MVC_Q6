using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Order/Default
        [AreaLogActionFilterAttribute]
        public ActionResult List()
        {
            //string result = "";
            //ArrayList url = new ArrayList();
            //url.Add((string)RouteData.Values["controller"]);
            //url.Add((string)RouteData.Values["Action"]);
            //foreach (var item in url)
            //{
            //    result = result + item + "/";
            //}
            //ViewBag.result = result;

            return View();
        }

        [AreaLogActionFilterAttribute]
        public ActionResult Detail()
        {
            return View();
        }

    }
}