#pragma checksum "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Shared\Components\Ads\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0353f7ba7a5dedc08f89fc40ab08ad6d55c647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Ads_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Ads/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Ads/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Ads_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0353f7ba7a5dedc08f89fc40ab08ad6d55c647", @"/Views/Shared/Components/Ads/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce8d1bbe8d975ac20f65c22d41aee78ff83b502", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Ads_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Session15.ViewAndHelpers.Models.Ads>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 3 "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Shared\Components\Ads\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(97, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(124, 9, false);
#line 6 "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Shared\Components\Ads\Default.cshtml"
       Write(item.Titr);

#line default
#line hidden
            EndContext();
            BeginContext(133, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 8 "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Shared\Components\Ads\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(157, 5, true);
            WriteLiteral("</ul>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Session15.ViewAndHelpers.Models.Ads>> Html { get; private set; }
    }
}
#pragma warning restore 1591