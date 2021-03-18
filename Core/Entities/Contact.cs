using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Contact : EntityBase
    {
    
        public string Name { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        
        [MaxLength(400)]
        public string Message { get; set; }
    }
}