#pragma checksum "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Home\Helpdesk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d545f936ce88ab91645d0819e4450b6de47e22c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Helpdesk), @"mvc.1.0.view", @"/Views/Home/Helpdesk.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d545f936ce88ab91645d0819e4450b6de47e22c", @"/Views/Home/Helpdesk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9b8993baaa3b0044252bd10d3a66211217b4ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Helpdesk : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/helpdesk.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d545f936ce88ab91645d0819e4450b6de47e22c4026", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d545f936ce88ab91645d0819e4450b6de47e22c4288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Home\Helpdesk.cshtml"
  
    ViewData["Title"] = "Helpdesk";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""faq-section"">
    <div class=""container"">
        <div class=""row"">
            <!-- ***** FAQ Start ***** -->
            <div class=""col-md-6 offset-md-3"">

                <div class=""faq-title text-center pb-3"">
                    <h2>Helpdesk</h2>
                </div>
                <div class=""text-center pb-8"">
                    <p>Hier worden de vaakgestelde vragen beantwoord. Staat uw vraag er niet tussen? Bereik de maker van de site op 19106297@student.hhs.nl<p>
                </div>

            </div>
            <div class=""col-md-6 offset-md-3"">
                <div class=""faq"" id=""accordion"">
                    <div class=""card"">
                        <div class=""card-header"" id=""faqHeading-1"">
                            <div class=""mb-0"">
                                <h5 class=""faq-title"" data-toggle=""collapse"" data-target=""#faqCollapse-1"" data-aria-expanded=""true"" data-aria-controls=""faqCollapse-1"">
                                    <span ");
            WriteLiteral(@"class=""badge"">1</span>Hoe beveiligen wij uw gegevens?
                                </h5>
                            </div>
                        </div>
                        <div id=""faqCollapse-1"" class=""collapse"" aria-labelledby=""faqHeading-1"" data-parent=""#accordion"">
                            <div class=""card-body"">
                                <p>Uw gegevens worden in een veilige database opgeslagen. Hier wordt uw wachtwoord automatisch versleuteld zodat deze niet direct in de database zijn te lezen.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""faqHeading-2"">
                            <div class=""mb-0"">
                                <h5 class=""faq-title"" data-toggle=""collapse"" data-target=""#faqCollapse-2"" data-aria-expanded=""false"" data-aria-controls=""faqCollapse-2"">
                                    <span class=""badge"">2</span> I");
            WriteLiteral(@"k kan niet meer inloggen
                                </h5>
                            </div>
                        </div>
                        <div id=""faqCollapse-2"" class=""collapse"" aria-labelledby=""faqHeading-2"" data-parent=""#accordion"">
                            <div class=""card-body"">
                                <p>Klik bij het inloggen op ""Wachtwoord vergeten"" om een nieuw wachtwoord aan te vragen. Indien u er nog steeds niet uitkomt, kunt u ons bereiken op 19106297@student.hhs.nl</p>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""faqHeading-3"">
                            <div class=""mb-0"">
                                <h5 class=""faq-title"" data-toggle=""collapse"" data-target=""#faqCollapse-3"" data-aria-expanded=""false"" data-aria-controls=""faqCollapse-3"">
                                    <span class=""badge"">3</span>Ik ben mijn wachtw");
            WriteLiteral(@"oord vergeten
                                </h5>
                            </div>
                        </div>
                        <div id=""faqCollapse-3"" class=""collapse"" aria-labelledby=""faqHeading-3"" data-parent=""#accordion"">
                            <div class=""card-body"">
                                <p>Klik bij het inloggen op ""Wachtwoord vergeten"" om een nieuw wachtwoord aan te vragen.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""faqHeading-4"">
                            <div class=""mb-0"">
                                <h5 class=""faq-title"" data-toggle=""collapse"" data-target=""#faqCollapse-4"" data-aria-expanded=""false"" data-aria-controls=""faqCollapse-4"">
                                    <span class=""badge"">4</span> Hoe verwijder ik mijn account
                                </h5>
                            </div>
      ");
            WriteLiteral(@"                  </div>
                        <div id=""faqCollapse-4"" class=""collapse"" aria-labelledby=""faqHeading-4"" data-parent=""#accordion"">
                            <div class=""card-body"">
                                <p>Klik op uw e-mail adres rechtsbovenin de navigatiebalk. Onder het kopje ""Persoonlijke data"" vindt u een knop om uw account - inclusief persoonlijke gegevens - in zijn geheel te verwijderen.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""faqHeading-5"">
                            <div class=""mb-0"">
                                <h5 class=""faq-title"" data-toggle=""collapse"" data-target=""#faqCollapse-5"" data-aria-expanded=""false"" data-aria-controls=""faqCollapse-5"">
                                    <span class=""badge"">5</span> Hoe is deze site gemaakt?
                                </h5>
                            </div>
  ");
            WriteLiteral(@"                      </div>
                        <div id=""faqCollapse-5"" class=""collapse"" aria-labelledby=""faqHeading-5"" data-parent=""#accordion"">
                            <div class=""card-body"">
                                <p>Deze site is gemaakt door Fabian van Hespen en Roderick Heijligers om voor onder andere stages te laten zien wat wij kunnen.</p>
                                <p>Om de site te maken is een van onze school projecten als basis gebruikt en deze hebben wij uitgebreid tot wat je nu ziet.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
