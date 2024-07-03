using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
    public class StudentVM
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string? Grade { get; set; }
    }
}
