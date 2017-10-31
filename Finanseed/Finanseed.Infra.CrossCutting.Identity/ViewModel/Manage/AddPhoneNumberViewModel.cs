using System.ComponentModel.DataAnnotations;

namespace Finanseed.Infra.CrossCutting.Identity.ViewModel.Manage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}
