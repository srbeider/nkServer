using nk.ServerBase.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace nk.ServerBase
{
    public class BaseController : Controller
    {
        public JsonResult JsonResponse(object data, string requestId)
        {
            var result = new ServiceResponse
            {
                Data = data,
                RequestId = requestId,
                ResponseCode = "200"
            };

            return base.Json(result);
        }

        public JsonResult JsonError(Exception exception, string requestId, string url)
        {
            var e = exception.GetBaseException();

            var result = new ServiceError
            {
                Message = e.Message,
                RequestId = requestId,
                ResponseCode = "500",
                Url = url
            };
            
            return base.Json(result);
        }
    }
}