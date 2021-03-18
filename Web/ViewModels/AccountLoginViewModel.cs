using System;
using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class AccountLoginViewModel
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public Boolean Remember { get; set; }
    }
}