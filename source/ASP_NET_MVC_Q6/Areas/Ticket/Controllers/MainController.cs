using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Ticket.Controllers
{
    public class MainController : Controller
    {
        // GET: Ticket/Main
        [AreaLogActionFilterAttribute]
        public ActionResult List()
        {
            return View();
        }
        [AreaLogActionFilterAttribute]
        public ActionResult Detail()
        {
            return View();
        }
    }
}