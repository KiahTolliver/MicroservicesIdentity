using System;
using AutoMapper;
using MicroservicesIdentity.Services.EventAPI.Models;
using MicroservicesIdentity.Services.EventAPI.Models.Dto;

namespace MicroservicesIdentity.Services.EventAPI
{
	public class MappingConfig
	{
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<EventDto, Event>();
                config.CreateMap<Event, EventDto>();
            });

            return mappingConfig;
        }

    }
}

