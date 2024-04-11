using System;
using MicroservicesIdentity.Web.Models;
using MicroservicesIdentity.Web.Service.IService;
using MicroservicesIdentity.Web.Utility;

namespace MicroservicesIdentity.Web.Service
{
	public class SessionService: ISessionService
	{
        private readonly IBaseService _baseService;
        public SessionService(IBaseService baseService)
		{
            _baseService = baseService;
		}

        public Task<ResponseDto?> CreateSessionAsync(SessionDto sessionDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteSessionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllSessionsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                //AccessToken = access_token,
                Url = SD.SessionAPIBase + "/api/session/"
            });
        }

        public Task<ResponseDto?> GetSessionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateSessionAsync(SessionDto sessionDto)
        {
            throw new NotImplementedException();
        }
    }
}

