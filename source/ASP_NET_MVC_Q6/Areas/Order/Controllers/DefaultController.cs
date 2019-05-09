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
        [LogActionFilterAttribute]
        public ActionResult List()
        {
            return View();
        }

        [LogActionFilterAttribute]
        public ActionResult Detail(string output)
        {
            return View();
        }

    }
}