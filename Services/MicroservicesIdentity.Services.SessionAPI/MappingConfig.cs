using AutoMapper;
using MicroservicesIdentity.Services.SessionAPI.Models;
using MicroservicesIdentity.Services.SessionAPI.Models.Dto;

namespace MicroservicesIdentity.Services.SessionAPI
{
	public class MappingConfig
	{
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<SessionDto, Session>();
                config.CreateMap<Session, SessionDto>();
            });

            return mappingConfig;
        }

    }
}

