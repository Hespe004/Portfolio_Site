#pragma checksum "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff9781284de0111d119688c793a95b1b36fe765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Details), @"mvc.1.0.view", @"/Views/Project/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff9781284de0111d119688c793a95b1b36fe765", @"/Views/Project/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9b8993baaa3b0044252bd10d3a66211217b4ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Project_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio_Site.Models.Project>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive margin rounded Center img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100% length:30%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OverzichtProjecten", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html>

<title>W3.CSS Template</title>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
<style>
    body, h1, h2, h3, h4, h5 {
        font-family: ""Raleway"", sans-serif
    }

    a.navbar-brand {
        white-space: normal;
        text-align: center;
        word-break: break-all;
    }

        a.navbar-brand:hover {
            color: #1da78b !important;
        }

    .navbar {
        padding-top: 15px;
        padding-bottom: 15px;
        border: 0;
        border-radius: 0;
        margin-bottom: 0;
        font-size: 12px;
        letter-spacing: 5px;
    }

    .navbar-nav li a:hover {
        color: #1da78b !important;
    }

    a {
        color: #ffffff;
    }

    .btn-primary {
        color: #fff;
        background-color: #1da78b;
        border-c");
            WriteLiteral(@"olor: #167a66;
    }

    .bg-custom {
        background-color: rgb(51, 51, 51);
    }

    /* Button used to open the contact form */
    .open-button {
        background-color: #555;
        color: white;
        padding: 16px 20px;
        border: none;
        cursor: pointer;
        opacity: 0.8;
        position: fixed;
        right: 28px;
        width: 350px;
    }

    /* The popup form - hidden by default */
    .form-popup {
        display: none;
        position: fixed;
        right: 15px;
        border: 3px solid #f1f1f1;
        z-index: 9;
        bottom: 0;
    }

    /* Add styles to the form container */
    .form-container {
        max-width: 300px;
        padding: 10px;
        background-color: white;
    }

    .Center {
        display: block;
        margin-left: auto;
        margin-right: auto;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff9781284de0111d119688c793a95b1b36fe7658157", async() => {
                WriteLiteral(@"

    <div class=""w3-content"" style=""max-width:1000px"">
        <!-- Grid -->
        <div class=""w3-row"">
            <!-- Blog entries -->
            <div class=""w3-col 12"">
                <div class=""w3-card-4 w3-margin w3-white"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ff9781284de0111d119688c793a95b1b36fe7658686", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                   WriteLiteral("~/Images/"+Model.ImageName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 102 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"w3-container\">\r\n                        <h3>\r\n                            <b> ");
#nullable restore
#line 105 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                           Write(Model.Titel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                        </h3>\r\n                        <h5>Categorie: ");
#nullable restore
#line 107 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                                  Write(Model.Categorie.Naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    </div>\r\n\r\n                    <div class=\"w3-container\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 112 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                       Write(Model.Omschrijving);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <div class=\"w3-row\">\r\n                            <div class=\"w3-col m6\">\r\n                                <h6 style=\"text-align:left\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff9781284de0111d119688c793a95b1b36fe76512524", async() => {
                    WriteLiteral("Terug naar overzicht");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 118 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                                     if ((bool)ViewData["UserIsModerator"])
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                                   Write(Html.Raw(" | "));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <i class=\"fa fa-close\" style=\"cursor:pointer; color:#B81414\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3497, "\"", 3598, 3);
                WriteAttributeValue("", 3507, "location.href=\'", 3507, 15, true);
#nullable restore
#line 121 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
WriteAttributeValue("", 3522, Url.Action("MeldingVerwijderen", "Meldings", new { Id = Model.MeldingID }), 3522, 75, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3597, "\'", 3597, 1, true);
                EndWriteAttribute();
                WriteLiteral("></i>\r\n");
#nullable restore
#line 122 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </h6>
                            </div>
                            <div class=""w3-col m6"">
                                <h6 style=""text-align:right;"">
                                    <i class=""fa fa-calendar""></i>");
#nullable restore
#line 127 "C:\Users\fabia\OneDrive\Documenten\HHS - ICT\Jaar 3\.Stage\Portfolio_Site\Views\Project\Details.cshtml"
                                                             Write(Model.Datum);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </h6>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div><br />\r\n            </div><br />\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n<script>\r\n    function openForm() {\r\n        document.getElementById(\"myForm\").style.display = \"block\";\r\n    }\r\n\r\n    function closeForm() {\r\n        document.getElementById(\"myForm\").style.display = \"none\";\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio_Site.Models.Project> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
