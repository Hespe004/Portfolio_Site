#pragma checksum "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "003bf0174bf2d73426ac18e95d5b2aaee6088fe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003bf0174bf2d73426ac18e95d5b2aaee6088fe0", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9b8993baaa3b0044252bd10d3a66211217b4ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n  <style>\r\n      form {\r\n          width: 400px;\r\n          height: 500px;\r\n      }\r\n  </style>\r\n  <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h1>Login</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "003bf0174bf2d73426ac18e95d5b2aaee6088fe03537", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""Email"">Email address</label>
                    <input type=""email"" class=""form-control"" id=""email"" aria-describedby=""emailHelp"" placeholder=""Vul hier je email in"">
                </div>
                <div class=""form-group"">
                    <label for=""Password"">Password</label>
                    <input type=""password"" class=""form-control"" id=""password"" placeholder=""Vul hier je password in"">
                </div>
                <br>
                <button type=""submit"" class=""btn btn-primary"">Inloggen</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"dropdown-divider\"></div>\r\n            <a class=\"dropdown-item\" href=\"#\">Forgot password? </a>\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <h1>Maak een nieuw account</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "003bf0174bf2d73426ac18e95d5b2aaee6088fe05668", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""Achternaam"">Voornaam</label>
                    <input type=""text"" class=""form-control"" id=""voornaam"" aria-describedby=""voornaamHelp"" placeholder=""Vul hier je voornaam in"">
                </div>
                <div class=""form-group"">
                    <label for=""Achternaam"">Achternaam</label>
                    <input type=""text"" class=""form-control"" id=""achternaam"" aria-describedby=""achternaamHelp"" placeholder=""Vul hier je achternaam in"">
                </div>
                <div class=""form-group"">
                    <label for=""Telefoonnummer"">Telefoonnummer</label>
                    <input type=""number"" class=""form-control"" id=""telefoonnummer"" aria-describedby=""telefoonnummerHelp"" placeholder=""Vul hier je telefoonnummer in"">
                </div>
                <div class=""form-group"">
                    <label for=""Email"">Email address</label>
                    <input type=""email"" class=""form-contro");
                WriteLiteral(@"l"" id=""email"" aria-describedby=""emailHelp"" placeholder=""Vul hier je email in"">
                </div>
                <div class=""form-group"">
                    <label for=""Password"">Password</label>
                    <input type=""password"" class=""form-control"" id=""password"" placeholder=""Vul hier je password in"">
                </div>
                <div class=""form-check"">
                    <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                    <label class=""form-check-label"" for=""exampleCheck1"">Ik accepteer de voorwaarden</label>
                </div>
                <small id=""="" class=""form-text text-muted"">Gebruik alsjeblieft niet uw bankwachtwoord. We hebben erg weinig moeite gestoken in de security van deze applicatie.</small>
                <br>
                <button type=""submit"" class=""btn btn-primary"">Aanmaken</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
