using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Product.Controllers
{
    public class MainController : Controller
    {

        [LogActionFilterAttribute]
        public ActionResult List()
        {
            return View();
        }
    }
}