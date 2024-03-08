using AutoMapper;
using MicroservicesIdentity.Services.SpeakerAPI.Models;
using MicroservicesIdentity.Services.SpeakerAPI.Models.Dto;

namespace MicroservicesIdentity.Services.SpeakerAPI
{
	public class MappingConfig
	{
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<SpeakerDto, Speaker>();
                config.CreateMap<Speaker, SpeakerDto>();
            });

            return mappingConfig;
        }

    }
}

