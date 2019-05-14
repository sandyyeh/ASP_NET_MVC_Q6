﻿using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    [LogActionFilterAttribute]
    public class ActionFilterController : Controller
    {
        // GET: ActionFilter
        public ActionResult Index()
        {
            return View();
        }
    }
}