#pragma checksum "C:\Users\Lenovo\source\repos\TruYum\TruYumClient\Views\Login\SelectAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31630c82089f0307762b3d1116f0e93d6c9bec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_SelectAction), @"mvc.1.0.view", @"/Views/Login/SelectAction.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\TruYum\TruYumClient\Views\_ViewImports.cshtml"
using TruYumClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\TruYum\TruYumClient\Views\_ViewImports.cshtml"
using TruYumClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31630c82089f0307762b3d1116f0e93d6c9bec3", @"/Views/Login/SelectAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f2381fb576fa1689ac0303a43a8f32ec3ef63c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_SelectAction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\TruYum\TruYumClient\Views\Login\SelectAction.cshtml"
  
    ViewData["Title"] = "SelectAction";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SelectAction</h1>\r\n<center>\r\n    <div class=\"container\">\r\n\r\n        <div>\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 145, "\'", 183, 1);
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\TruYum\TruYumClient\Views\Login\SelectAction.cshtml"
WriteAttributeValue("", 152, Url.Action("ViewMenu", "Menu"), 152, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\'button\' value=\'Menu Items\' />\r\n            </a>\r\n        </div>\r\n        <br />\r\n        <div>\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 326, "\'", 363, 1);
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\TruYum\TruYumClient\Views\Login\SelectAction.cshtml"
WriteAttributeValue("", 333, Url.Action("GetCart", "Cart"), 333, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\'button\' value=\'Cart\' />\r\n            </a>\r\n        </div>\r\n    </div>\r\n</center>\r\n\r\n");
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
