using System.ComponentModel.DataAnnotations;
namespace CommandAPI.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string HowTo { get; set; }
        [Required]
        public string PlatForm { get; set; }
        [Required]
        public string CommandLine { get; set; }

    }
}