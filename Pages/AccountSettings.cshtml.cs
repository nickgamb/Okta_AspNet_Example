using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Okta_AspNet_Example.Pages
{
    public class AccountSettingsModel : PageModel
    {
        private readonly ILogger<AccountSettingsModel> _logger;

        public AccountSettingsModel(ILogger<AccountSettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}