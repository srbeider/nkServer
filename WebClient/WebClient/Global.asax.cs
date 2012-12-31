using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebClient
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            var filters = GlobalFilters.Filters;
            filters.Add(new ServiceCallFilter());
            FilterConfig.RegisterGlobalFilters(filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }

    public class ServiceCallFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.Equals("Users"))
            {
                var url = string.Format(@"http://localhost:51895/{0}/{1}", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName);
                var uri = new Uri(url, UriKind.Absolute);
                var request = WebRequest.Create(uri);
                request.Method = "POST";
                
                var response = request.GetResponse();
                var s = response.GetResponseStream();
                var sr = new StreamReader(s, Encoding.ASCII);
                var result = sr.ReadToEnd();
                filterContext.Result = new JsonResult();
                WriteResponse(result, filterContext);
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }
        }

        private void WriteResponse(string txt, ControllerContext filterContext)
        {
            var response = filterContext.HttpContext.Response;
            if (response.ContentType == "text/html")
            {
                response.Write(txt);
            }
        }
    }
}