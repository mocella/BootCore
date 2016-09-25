using System.ComponentModel.DataAnnotations;

namespace BootCore.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "example@example.org")]
        public string Email { get; set; }
    }
}
