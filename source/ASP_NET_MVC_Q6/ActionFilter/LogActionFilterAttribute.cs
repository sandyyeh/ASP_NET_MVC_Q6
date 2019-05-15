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
            var areaName = "area";
            string[] key = { "controller", "action", "id", "page", "category" };
            ArrayList url = new ArrayList();

            if (areaName != null)
            {
                url.Add((string)routeData.DataTokens[areaName]);
            }
            foreach (var item in key)
            {
                if (!string.IsNullOrEmpty((string)routeData.Values[item]))
                {
                    url.Add((string)routeData.Values[item]);

                    if ((item == "id" || item == "page") && !(int.TryParse((string)routeData.Values[item], out int num)))
                    {
                        url.Clear();
                        result = "URL is Wrong!";
                    }

                }
            }

            foreach (var item in url)
            {
                result = result + item + "/";
            }

            _output.WriteLine(result);
        }

    }

}