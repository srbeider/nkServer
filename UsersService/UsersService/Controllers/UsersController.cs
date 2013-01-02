using nk.ServerBase;
using nk.ServerBase.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace UsersService.Controllers
{
    public class UsersController : BaseController
    {
        private class UserPlugged
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        private List<UserPlugged> users = new List<UserPlugged>
        {
            new UserPlugged { Id = "1", Name = "Núria" },
            new UserPlugged { Id = "2", Name = "Marc" },
            new UserPlugged { Id = "3", Name = "Pablo" },
            new UserPlugged { Id = "4", Name = "Ray" },
            new UserPlugged { Id = "5", Name = "Steff" }
        };

        [HttpPost]
        public JsonResult GetUserById(ServiceArgs<string> data)
        {
            try
            {
                var result = users.FirstOrDefault(u => u.Equals(data.Args));
                return JsonResponse(result, data.RequestId);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }

        public JsonResult Nuria()
        {
            try
            {
                Thread.Sleep(10000);
                var result = users.FirstOrDefault(u => u.Equals("1"));
                return JsonResponse(result, null);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }

        public JsonResult Marc()
        {
            try
            {
                Thread.Sleep(10000);
                var result = users.FirstOrDefault(u => u.Equals("2"));
                throw new Exception("A petarlo to!");
                return JsonResponse(result, null);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }

        public JsonResult Pablo()
        {
            try
            {
                Thread.Sleep(10000);
                var result = users.FirstOrDefault(u => u.Equals("3"));
                return JsonResponse(result, null);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }

        public JsonResult Ray()
        {
            try
            {
                Thread.Sleep(10000);
                var result = users.FirstOrDefault(u => u.Equals("4"));
                return JsonResponse(result, null);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }

        public JsonResult Steff()
        {
            try
            {
                Thread.Sleep(10000);
                var result = users.FirstOrDefault(u => u.Equals("5"));
                return JsonResponse(result, null);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }
    }
}