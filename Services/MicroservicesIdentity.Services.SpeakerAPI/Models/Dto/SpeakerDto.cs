using System;
namespace MicroservicesIdentity.Services.SpeakerAPI.Models.Dto
{
	public class SpeakerDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Bio { get; set; }
        public string EmailAddress { get; set; }
    }
}

