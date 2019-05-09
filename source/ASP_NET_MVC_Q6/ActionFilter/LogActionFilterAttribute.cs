using System;
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
    public class LogActionFilterAttribute : ActionFilterAttribute
    {

        private HttpWriter _output;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            Url(filterContext.RouteData);

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
        void Url(RouteData routeData)
        {
            string result = "";
            ArrayList url = new ArrayList();
            if (!string.IsNullOrEmpty((string)routeData.Values["area"]))
            {
                url.Add((string)routeData.Values["area"]);
            }
            if (!string.IsNullOrEmpty((string)routeData.Values["controller"]))
            {
                url.Add((string)routeData.Values["controller"]);
            }
            if (!string.IsNullOrEmpty((string)routeData.Values["action"]))
            {
                url.Add((string)routeData.Values["action"]);
            }
            if (!string.IsNullOrEmpty((string)routeData.Values["id"]))
            {
                if (int.TryParse((string)routeData.Values["id"], out int num))
                {
                    url.Add((string)routeData.Values["id"]);
                }
                else
                {
                    url.Clear();
                    result = "URL is wrong!";
                }
            }
            if (!string.IsNullOrEmpty((string)routeData.Values["page"]))
            {
                if (int.TryParse((string)routeData.Values["page"], out int num2))
                {
                    url.Add((string)routeData.Values["page"]);
                }
                else
                {
                    url.Clear();
                    result = "URL is wrong!";
                }
            }
            if (!string.IsNullOrEmpty((string)routeData.Values["category"]))
            {
                url.Add((string)routeData.Values["category"]);
            }
            foreach (var item in url)
            {
                result = result + item + "/";
            }
            _output.WriteLine(result);
        }


    }

}