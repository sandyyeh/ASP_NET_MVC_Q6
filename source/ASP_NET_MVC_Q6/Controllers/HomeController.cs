﻿using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    public class HomeController: ActionFilterController
    {
    
        public ActionResult Welcome()
        {
            return View();
        }
    
        public ActionResult ContactMe()
        {
            return View();
        }
    }
}