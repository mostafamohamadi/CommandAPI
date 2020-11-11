using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(255)]
        public string HowTo { get; set; }
        [Required]
        public string PlatForm { get; set; }
        [Required]
        public string CommandLine { get; set; }
    }
}