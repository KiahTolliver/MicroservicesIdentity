using System;
using MicroservicesIdentity.Web.Models;
using MicroservicesIdentity.Web.Service.IService;
using MicroservicesIdentity.Web.Utility;

namespace MicroservicesIdentity.Web.Service
{
	public class EventService: IEventService
	{
        private readonly IBaseService _baseService;
		public EventService(IBaseService baseService )
		{
            _baseService = baseService;
		}

        public Task<ResponseDto?> CreateEventAsync(EventDto eventDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteEventAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllEventsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                //AccessToken = access_token,
                Url = SD.EventAPIBase + "/api/event/"
            });
        }

        public Task<ResponseDto?> GetEventByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateEventAsync(EventDto eventDto)
        {
            throw new NotImplementedException();
        }
    }
}

