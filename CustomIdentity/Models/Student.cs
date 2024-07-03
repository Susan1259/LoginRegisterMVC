using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string? Grade { get; set; }
    }
}
