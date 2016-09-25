namespace BootCore.ViewModels.Account
{
    public class RegisterViewModel : IUserConfirmPassword
    {
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
    }
}
