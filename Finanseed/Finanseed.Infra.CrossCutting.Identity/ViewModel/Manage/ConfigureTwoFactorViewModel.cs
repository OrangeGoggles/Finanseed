using System.Collections.Generic;
using System.Web.Mvc;

namespace Finanseed.Infra.CrossCutting.Identity.ViewModel.Manage
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}
