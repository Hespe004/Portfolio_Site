#pragma checksum "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Home\Rondleiding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71a7043a0234d4caba0c523e014e1da04c22e384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rondleiding), @"mvc.1.0.view", @"/Views/Home/Rondleiding.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71a7043a0234d4caba0c523e014e1da04c22e384", @"/Views/Home/Rondleiding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9b8993baaa3b0044252bd10d3a66211217b4ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rondleiding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Home\Rondleiding.cshtml"
  
    ViewData["Title"] = "Rondleiding";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a7043a0234d4caba0c523e014e1da04c22e3844423", async() => {
                WriteLiteral(@"
    <title>W3.CSS Template</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""/css/home.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71a7043a0234d4caba0c523e014e1da04c22e3844963", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <style>
        .fa-anchor, .fa-coffee {
            font-size: 200px
        }

        .fa-lock {
            font-size: 200px;
        }


    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a7043a0234d4caba0c523e014e1da04c22e3847137", async() => {
                WriteLiteral(@"

    <section class=""faq-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 offset-md-3"">

                    <div class=""faq-title text-center pb-3"">
                        <h2>Rondleiding BuurSecure</h2>
                    </div>
                    <div class=""text-center pb-8"">
                        <p>
                            Hier volgt een rondleiding over BuurSecure waar de site voor u wordt uitgelegdt.
                            Mocht u hier geen interesse in hebben kunt u via de header terug naar de site.
                        <p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-light-grey w3-padding-64 w3-container"">
            <div class=""w3-content"">


                <div class=""w3-twothird"">
                    <h1>Hoe werkt de rondleiding?</h1>
                    <p class=""w3-text-grey"">
                        Door op de o");
                WriteLiteral(@"nderstaande knop te drukken zal de pop-up rondleiding over BuurSecure aangezet worden. U ziet dan een pop-up onder de header verschijnen met basis-informatie.
                        <br>
                        Hieronder staan de pagina's in meer details uitgelegd.
                    </p>
                    <button id=""rondleidingAan"" onclick=""rondleidingAan()"">Start rondleiding</button>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-padding-64 w3-container"">
            <div class=""w3-content"">
                <div class=""w3-twothird"">
                    <h1>Homepage</h1>
                    <p class=""w3-text-grey"">
                        Op de homepagina kunt u informatie over BuurSecure lezen. Hieronder valt wat Buursecure is, wie wij zijn en wat u op BuurSecure kunt.
                    </p>
                </div>


            </div>
        </div>

        <div class=""w3-row-padding w3-light-grey w3-padding-64 w3-container"">
  ");
                WriteLiteral(@"          <div class=""w3-content"">


                <div class=""w3-twothird"">
                    <h1>Chat</h1>
                    <p class=""w3-text-grey"">
                        Via de chat kunt u met op dat moment andere ingelogde gebruikers discuseren over bijvoorbeeld problemen die er op dat moment zijn. Let op, hier wordt uw email als gebruikernaam gebruikt en andere kunnen dit zien.
                    </p>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-padding-64 w3-container"">
            <div class=""w3-content"">
                <div class=""w3-twothird"">
                    <h1>Helpdesk</h1>
                    <p class=""w3-text-grey"">
                        Op de helpdesk kunt u de meest gestelde vragen bekijken en staat onze email voor als u ons wilt contacteren.
                    </p>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-light-grey w3-padding-64 w3-container"">
  ");
                WriteLiteral(@"          <div class=""w3-content"">
                <div class=""w3-twothird"">
                    <h1>Meldingen</h1>
                    <p class=""w3-text-grey"">
                        Dit is de pagina waar BuurSecure om draait, u kunt kiezen of u alle meldingen wilt zien. Hier staat een overzicht met alle meldingen van andere gebruikers en die van u zelf. Op meldingen kan gereageerd worden zodat u samen naar een oplossing kan zoeken.
                        Meldingen kunnen worden geliked, worden inclusief datum vermeld en laten het aantal reacties en aantal keer bekeken zien. Via deze knop kunt u ook uw meldingen zien en uw anonieme meldingen. Alle meldingen kunnen worden gesorteerd en hebben een zoekfunctie.
                    </p>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-padding-64 w3-container"">
            <div class=""w3-content"">
                <div class=""w3-twothird"">
                    <h1>Melding maken</h1>
                   ");
                WriteLiteral(@" <p class=""w3-text-grey"">
                        Hier kunt u een melding maken, dit kan publiek worden gedaan of anoniem. Anonieme meldingen zijn alleen zichtbaar voor moderators en verder kan niemand behalve jijzelf dit zien.
                    </p>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-light-grey w3-padding-64 w3-container"">
            <div class=""w3-content"">
                <div class=""w3-twothird"">
                    <h1>Account</h1>
                    <p class=""w3-text-grey"">
                        U kunt naar een account pagina waar u al uw account data kunt bijwerken en zo nodig verwijderen.
                        Ook kunt u via deze knop terug naar deze rondleiding.
                    </p>
                </div>
            </div>
        </div>

        <div class=""w3-row-padding w3-padding-64 w3-container"">
            <div class=""w3-content"">
                <div class=""w3-twothird"">
                    <h1>Log");
                WriteLiteral(@" uit</h1>
                    <p class=""w3-text-grey"">
                        Via deze knop kunt u weer uitloggen. Bedankt voor het bekijken van deze rondleiding en veel plezier op BuurSecure.
                    </p>
                </div>
            </div>
        </div>
    </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>
    function rondleidingAan() {
        document.getElementById(""rondleiding0"").style.visibility = ""visible"";
    }
    function rondleidingVolgende(spandieuitmoet, spandieaanmoet) {
        document.getElementById(spandieuitmoet).style.visibility = ""hidden"";
        document.getElementById(spandieaanmoet).style.visibility = ""visible"";
    }
    function rondleidingUit() {
        document.getElementById(""rondleidingFinal"").style.visibility = ""hidden"";
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
