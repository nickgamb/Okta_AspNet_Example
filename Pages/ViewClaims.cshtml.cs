using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Okta_AspNet_Example.Pages
{
    public class ViewClaimsModel : PageModel
    {
        private readonly ILogger<ViewClaimsModel> _logger;

        public ViewClaimsModel(ILogger<ViewClaimsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}