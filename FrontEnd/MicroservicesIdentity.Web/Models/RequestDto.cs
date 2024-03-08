using System;
using MicroservicesIdentity.Web.Utility;
using static MicroservicesIdentity.Web.Utility.SD;

namespace MicroservicesIdentity.Web.Models
{
	public class RequestDto
	{
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        
    }
}

