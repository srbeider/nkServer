using nk.ServerBase.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebClient.Filters
{
    public class ServiceCallAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.Equals("Users"))
            {
                var url = string.Format(@"http://localhost:51895/{0}/{1}", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName);
                var uri = new Uri(url, UriKind.Absolute);

                try
                {
                    var request = WebRequest.Create(uri);
                    request.Method = "POST";
                    var response = request.GetResponse();
                    var s = response.GetResponseStream();
                    var sr = new StreamReader(s, Encoding.ASCII);
                    var result = sr.ReadToEnd();
                    filterContext.Result = new JsonResult();
                    WriteResponse(result, filterContext);
                }
                catch (Exception e)
                {
                    var exception = e.GetBaseException();
                    var serviceError = new ServiceError
                    {
                        ResponseCode = "404",
                        Url = url,
                        Message = exception.Message
                    };

                    var result = new JsonResult();
                    result.Data = serviceError;
                    filterContext.Result = result;
                }
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