#pragma checksum "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Shared\_ModeratorPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48346cae71b8f579aea3e4adca6e626caa51323e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModeratorPartial), @"mvc.1.0.view", @"/Views/Shared/_ModeratorPartial.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\_ViewImports.cshtml"
using Portfolio_Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\_ViewImports.cshtml"
using Portfolio_Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Shared\_ModeratorPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Shared\_ModeratorPartial.cshtml"
using Portfolio_Site.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48346cae71b8f579aea3e4adca6e626caa51323e", @"/Views/Shared/_ModeratorPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9b8993baaa3b0044252bd10d3a66211217b4ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModeratorPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"navbar-nav text-color\">\r\n\r\n</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<_Portfolio_Site_User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<_Portfolio_Site_User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
