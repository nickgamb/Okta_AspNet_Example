#pragma checksum "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1cef2978622f4e506277fcc3f76bdf7703329b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Okta_AspNet_Example.Pages.Pages_ViewClaims), @"mvc.1.0.razor-page", @"/Pages/ViewClaims.cshtml")]
namespace Okta_AspNet_Example.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/_ViewImports.cshtml"
using Okta_AspNet_Example;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1cef2978622f4e506277fcc3f76bdf7703329b", @"/Pages/ViewClaims.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd4c65a2bfc49fed7f1439aca55d45eed8eaa4f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewClaims : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
  
    ViewData["Title"] = "Claims";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<section id=\"claims-section\" class=\"u-content-space\">\n    <div class=\"text-center\">\n        <h2 class=\"h1 font-weight-light mb-1\">");
#nullable restore
#line 11 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
                                         Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Claims</h2>\n");
#nullable restore
#line 12 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
         foreach (var claim in ((ClaimsIdentity)User.Identity).Claims)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt");
            BeginWriteAttribute("title", " title=\"", 361, "\"", 380, 1);
#nullable restore
#line 14 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
WriteAttributeValue("", 369, claim.Type, 369, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
                               Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n            <dd>");
#nullable restore
#line 15 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
           Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n");
#nullable restore
#line 16 "/Users/nickgamb/Documents/GitHub/Okta_AspNet_Example/Pages/ViewClaims.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewClaimsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViewClaimsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViewClaimsModel>)PageContext?.ViewData;
        public ViewClaimsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
