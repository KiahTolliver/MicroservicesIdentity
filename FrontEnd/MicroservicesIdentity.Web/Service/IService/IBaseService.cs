using System;
using MicroservicesIdentity.Web.Models;

namespace MicroservicesIdentity.Web.Service.IService
{
	public interface IBaseService
	{
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}

