#pragma checksum "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/Hello/Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7c2c6bfaa8fe0c4cf6a0d319cc305f40144c53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Welcome), @"mvc.1.0.razor-page", @"/Views/Hello/Welcome.cshtml")]
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
#line 1 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/_ViewImports.cshtml"
using HelloASPDotNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/_ViewImports.cshtml"
using HelloASPDotNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7c2c6bfaa8fe0c4cf6a0d319cc305f40144c53", @"/Views/Hello/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b363ed605a6ec37a2af0172d64306c5d328b8d4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_Welcome : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/Hello/Welcome.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/Hello/Welcome.cshtml"
 if (ViewBag.person == null || ViewBag.person == "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>WelCome World!</h1>\n");
#nullable restore
#line 9 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/Hello/Welcome.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>WelCome ");
#nullable restore
#line 12 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/Hello/Welcome.cshtml"
           Write(ViewBag.person);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\n");
#nullable restore
#line 13 "/Users/mymac/Desktop/C#2 /Practice/HelloASPDotNET/Views/Hello/Welcome.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Hello_Welcome> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Hello_Welcome> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Hello_Welcome>)PageContext?.ViewData;
        public Views_Hello_Welcome Model => ViewData.Model;
    }
}
#pragma warning restore 1591
