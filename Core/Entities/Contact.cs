using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Contact : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [MaxLength(400)]
        public string Message { get; set; }
    }
}