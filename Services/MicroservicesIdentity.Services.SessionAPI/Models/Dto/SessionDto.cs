using System;
namespace MicroservicesIdentity.Services.SessionAPI.Models.Dto
{
	public class SessionDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abstract { get; set; }
        public string SpeakerName { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public string Location { get; set; }
    }
}

