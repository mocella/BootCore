using System.ComponentModel.DataAnnotations;

namespace BootCore.ViewModels.Account
{
    public interface IUserConfirmPassword
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "example@example.org")]
        string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [Display(Prompt = "password")]
        [DataType(DataType.Password)]
        string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password", Prompt = "password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        string ConfirmPassword { get; set; }
    }
}