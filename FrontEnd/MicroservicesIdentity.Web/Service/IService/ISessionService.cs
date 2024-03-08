using System;
using MicroservicesIdentity.Web.Models;

namespace MicroservicesIdentity.Web.Service.IService
{
	public interface ISessionService
	{
        Task<ResponseDto?> GetAllSessionsAsync();
        Task<ResponseDto?> GetSessionByIdAsync(int id);
        Task<ResponseDto?> CreateSessionAsync(SessionDto sessionDto);
        Task<ResponseDto?> UpdateSessionAsync(SessionDto sessionDto);
        Task<ResponseDto?> DeleteSessionAsync(int id);
    }
}

