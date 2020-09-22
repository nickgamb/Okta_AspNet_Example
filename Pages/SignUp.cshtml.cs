using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Okta.Sdk;

namespace Okta_AspNet_Example.Pages
{
    public class SignUpModel : PageModel
    {
        /**************************
         * Set Bind Properties    *
         **************************/

        [BindProperty]
        public string EmailInput { get; set; }
        [BindProperty]
        public string FirstNameInput { get; set; }
        [BindProperty]
        public string LastNameInput { get; set; }

        /**************************
        * Class Configuration     *
        ***************************/
        private readonly IConfiguration Configuration;
        private readonly ILogger<SignUpModel> _logger;

        public SignUpModel(ILogger<SignUpModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration; 
        }

        /**************************
        * Sign Up Submit          *
        ***************************/
        public ActionResult OnPostSignup()
        {
            try
            {
                var client = new OktaClient(new Okta.Sdk.Configuration.OktaClientConfiguration
                {
                    OktaDomain = Configuration.GetValue<string>("Okta:OktaDomain"),
                    Token = Configuration.GetValue<string>("Okta:APIToken")
                });

                // Create a user with the specified password
                //TODO: Add capcha to protect from spam. Add more profile bits like phone for mfa. https://blog.davem.dev/2019/03/integrating-google-recaptcha-v2-with.html
                //TODO: Do a check to make sure that the username is unique or there will be a crash
                var createUserResponse = client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
                {
                    // User profile object
                    Profile = new UserProfile
                    {
                        FirstName = FirstNameInput,
                        LastName = LastNameInput,
                        Email = EmailInput,
                        Login = EmailInput
                    },
                    Activate = true,
                }).Result;
            }
            catch (Exception ex)
            {
                //TODO: Handle Errors
            }

            return Redirect("Index?pendingSignUp=true");
        }
    }
}