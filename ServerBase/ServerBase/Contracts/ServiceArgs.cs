using System;
namespace nk.ServerBase.Contracts
{
    [Serializable]
    public class ServiceArgs<T>
    {
        public string RequestId { get; set; }
        public T Args { get; set; }
    }
}