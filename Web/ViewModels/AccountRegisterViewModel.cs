using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

         [Required]
         [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and Confirmation password do not match.")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}