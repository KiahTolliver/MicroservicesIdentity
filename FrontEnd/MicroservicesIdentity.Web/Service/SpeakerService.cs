using System;
using MicroservicesIdentity.Web.Models;
using MicroservicesIdentity.Web.Service.IService;
using MicroservicesIdentity.Web.Utility;

namespace MicroservicesIdentity.Web.Service
{
	public class SpeakerService: ISpeakerService
	{
        private readonly IBaseService _baseService;
        public SpeakerService(IBaseService baseService)
		{
            _baseService = baseService;
		}

        public Task<ResponseDto?> CreateSpeakerAsync(SpeakerDto speakerDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteSpeakerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllSpeakersAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                //AccessToken = access_token,
                Url = SD.SpeakerAPIBase + "/api/speaker/"
            });
        }

        public Task<ResponseDto?> GetSpeakerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateSpeakerAsync(SpeakerDto speakerDto)
        {
            throw new NotImplementedException();
        }
    }
}

