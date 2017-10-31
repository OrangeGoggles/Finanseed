using System.ComponentModel.DataAnnotations;

namespace Finanseed.Infra.CrossCutting.Identity.ViewModel.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
