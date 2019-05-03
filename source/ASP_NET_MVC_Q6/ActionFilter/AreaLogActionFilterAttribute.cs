﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class AreaLogActionFilterAttribute : ActionFilterAttribute
    {
        private HttpWriter output;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            url(filterContext.RouteData);

        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }
        void url(RouteData routeData)
        {
            string result = "";
            ArrayList url = new ArrayList();
            url.Add((string)routeData.Values["area"]);
            url.Add((string)routeData.Values["controller"]);
            url.Add((string)routeData.Values["action"]);
            url.Add((string)routeData.Values["Id"]??"");
            url.Add((string)routeData.Values["category"]??"");

            foreach (var item in url)
            {
                //if (item==null) { url.Remove(item); }
                result = result + item + "/";
            }
            output.WriteLine(result);
        }

    }

}