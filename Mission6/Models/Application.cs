using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [Range(1900, 2099)]
        public int Year { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}