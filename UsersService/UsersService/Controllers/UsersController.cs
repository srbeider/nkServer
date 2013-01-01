using nk.ServerBase;
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
        private class User
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public JsonResult Index()
        {
            try
            {
                var result = new User { Id = "2", Name = "Marc" };
                return JsonResponse(result, null);
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
                var result = new User { Id = "1", Name = "Nuria" };
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
                var result = new User { Id = "2", Name = "Marc" };
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
                var result = new User { Id = "3", Name = "Pablo" };
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
                var result = new User { Id = "4", Name = "Ray" };
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
                var result = new User { Id = "5", Name = "Steff" };
                return JsonResponse(result, null);
            }
            catch (Exception e)
            {
                return JsonError(e, null, Request.Url.AbsoluteUri);
            }
        }
    }
}