#pragma checksum "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e8cb5b0e32361272b8f0e8fdd265b435c42867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProfessionPage), @"mvc.1.0.view", @"/Views/Home/ProfessionPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e8cb5b0e32361272b8f0e8fdd265b435c42867", @"/Views/Home/ProfessionPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fae45fac59a103e47e1d4209d290986cabb12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProfessionPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Card>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Fullname</th>
                <th>Profession</th>
                <th>Email</th>
                <th>Phone Number</th>
                
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
             foreach (Card profession in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
                   Write(profession.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
                   Write(profession.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
                   Write(profession.Profession.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
                   Write(profession.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
                   Write(profession.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\efend\source\repos\MVC-Task-4\MVC-Task-4\Views\Home\ProfessionPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Card>> Html { get; private set; }
    }
}
#pragma warning restore 1591
