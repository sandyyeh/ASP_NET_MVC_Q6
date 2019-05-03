using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Order/Default
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

    }
}