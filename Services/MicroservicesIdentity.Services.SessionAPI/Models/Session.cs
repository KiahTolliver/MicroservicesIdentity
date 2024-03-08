using System.ComponentModel.DataAnnotations;

namespace MicroservicesIdentity.Services.SessionAPI.Models
{
	public class Session
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Abstract { get; set; }
        [Required]
        public string SpeakerName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public string Location { get; set; }
    }
}

