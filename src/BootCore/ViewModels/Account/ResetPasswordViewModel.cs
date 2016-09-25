namespace BootCore.ViewModels.Account
{
    public class ResetPasswordViewModel : IUserConfirmPassword
    {

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
