using System;
using System.ComponentModel.DataAnnotations;

namespace MicroservicesIdentity.Services.SpeakerAPI.Models
{
	public class Speaker
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Company { get; set; }
        public string Bio { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}

