using System.ComponentModel.DataAnnotations;

namespace BootCore.ViewModels
{
    public class LoginViewModel
    {
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email", Prompt="example@example.org")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Prompt = "password")]
        public string Password { get; set; }
    }
}
