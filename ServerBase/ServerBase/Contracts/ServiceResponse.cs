using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nk.ServerBase.Contracts
{
    public class ServiceResponse
    {
        public string ResponseCode { get; set; }
        public string RequestId { get; set; }
        public object Data { get; set; }
    }
}
