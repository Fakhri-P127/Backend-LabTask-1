#pragma checksum "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4056d48e4ca6f9ad870616560cac9d40b5debb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\_ViewImports.cshtml"
using MVC_Task_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d4056d48e4ca6f9ad870616560cac9d40b5debb", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fae45fac59a103e47e1d4209d290986cabb12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Card>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "professionpage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
		<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 822, "\"", 840, 1);
#nullable restore
#line 26 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 828, Model.Image, 828, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"teacher\">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 31 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                   Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d4056d48e4ca6f9ad870616560cac9d40b5debb5153", async() => {
                WriteLiteral("\r\n                        <h5>");
#nullable restore
#line 33 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                       Write(Model.Profession.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                                                                           WriteLiteral(Model.Profession.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4>about me</h4>\r\n                        <p>");
#nullable restore
#line 36 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                      Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <ul>
                            <li><span>degree: </span>PHD in Micro Biology</li>
                            <li><span>experience: </span>7 years experience</li>
                            <li><span>hobbies: </span>music, travelling, catching fish</li>
                            <li><span>faculty: </span>Din, Department of Micro Biology</li>
                        </ul>
</div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 50 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 51 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                                             Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span> stuart.k</p>\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2225, "\"", 2250, 1);
#nullable restore
#line 54 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2232, Model.FacebookUrl, 2232, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2254, "\"", 2281, 1);
#nullable restore
#line 54 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2262, Model.FacebookIcon, 2262, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2328, "\"", 2354, 1);
#nullable restore
#line 55 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2335, Model.PinterestUrl, 2335, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2358, "\"", 2386, 1);
#nullable restore
#line 55 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2366, Model.PinterestIcon, 2366, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2433, "\"", 2455, 1);
#nullable restore
#line 56 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2440, Model.VimeoUrl, 2440, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2459, "\"", 2483, 1);
#nullable restore
#line 56 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2467, Model.VimeoIcon, 2467, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2530, "\"", 2554, 1);
#nullable restore
#line 57 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2537, Model.TwitterUrl, 2537, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2558, "\"", 2584, 1);
#nullable restore
#line 57 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue("", 2566, Model.TwitterIcon, 2566, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 67 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                         foreach (Skill skill in Model.Skills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-4\">\r\n                                <div class=\"skill-bar-item\">\r\n                                    <span>");
#nullable restore
#line 71 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                                     Write(skill.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <div class=\"progress\">\r\n                                        <div data-wow-delay=\"0.4s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 3323, "\"", 3451, 11);
            WriteAttributeValue("", 3331, "width:", 3331, 6, true);
#nullable restore
#line 73 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
WriteAttributeValue(" ", 3337, skill.Percent, 3338, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3352, ";", 3352, 1, true);
            WriteAttributeValue(" ", 3353, "visibility:", 3354, 12, true);
            WriteAttributeValue(" ", 3365, "visible;", 3366, 9, true);
            WriteAttributeValue(" ", 3374, "animation-duration:", 3375, 20, true);
            WriteAttributeValue(" ", 3394, "1.5s;", 3395, 6, true);
            WriteAttributeValue(" ", 3400, "animation-delay:", 3401, 17, true);
            WriteAttributeValue(" ", 3417, "1.2s;", 3418, 6, true);
            WriteAttributeValue(" ", 3423, "animation-name:", 3424, 16, true);
            WriteAttributeValue(" ", 3439, "fadeInLeft;", 3440, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
#nullable restore
#line 74 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"
                                                              Write(skill.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 79 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\Details.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Card> Html { get; private set; }
    }
}
#pragma warning restore 1591
