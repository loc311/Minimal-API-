using System.ComponentModel.DataAnnotations;

namespace MinAPI.Dtos
{
    public class CommandCreateDto 
    {
        

        [Required]
        public string? HowTo {get; set;}

        [Required]
        [MaxLength(5)]
        public string? Flatform {get; set;}

        [Required]
        public string? CommandLine { get; set; }
    }
}