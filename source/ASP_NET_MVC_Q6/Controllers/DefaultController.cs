using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    public class DefaultController: ActionFilterController
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);


            // TODO：準備開始實作
        }



 
        public ActionResult Login()
        {
          
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

    }
}