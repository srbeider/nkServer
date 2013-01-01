using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nk.ServerBase.Contracts
{
    public class ServiceError
    {
        public string ResponseCode { get; set; }
        public string RequestId { get; set; }
        public string Url { get; set; }
        public string Message { get; set; }
    }
}
