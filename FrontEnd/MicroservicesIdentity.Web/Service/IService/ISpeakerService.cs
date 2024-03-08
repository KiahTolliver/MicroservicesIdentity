using System;
using MicroservicesIdentity.Web.Models;

namespace MicroservicesIdentity.Web.Service.IService
{
	public interface ISpeakerService
	{
        Task<ResponseDto?> GetAllSpeakersAsync();
        Task<ResponseDto?> GetSpeakerByIdAsync(int id);
        Task<ResponseDto?> CreateSpeakerAsync(SpeakerDto speakerDto);
        Task<ResponseDto?> UpdateSpeakerAsync(SpeakerDto speakerDto);
        Task<ResponseDto?> DeleteSpeakerAsync(int id);
    }
}

