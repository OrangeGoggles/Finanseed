using System.ComponentModel.DataAnnotations;

namespace Finanseed.Infra.CrossCutting.Identity.ViewModel.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
