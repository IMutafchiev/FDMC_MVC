#pragma checksum "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\Cats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d9015ed98324c7393d8f0206b262ae8d3605771"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cats_Details), @"mvc.1.0.view", @"/Views/Cats/Details.cshtml")]
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
#line 1 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\_ViewImports.cshtml"
using FDMC_MVC.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\_ViewImports.cshtml"
using FDMC_MVC.App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9015ed98324c7393d8f0206b262ae8d3605771", @"/Views/Cats/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91f29f8866201f170a4dc479f996cf961bed6a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FDMC_MVC.App.ViewModels.Cats.ViewModels.CatDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\Cats\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\Cats\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 149, "\"", 170, 1);
#nullable restore
#line 9 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\Cats\Details.cshtml"
WriteAttributeValue("", 155, Model.ImageUrl, 155, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"250\" />\r\n\r\n<br />\r\n\r\n\r\n<h6>Age: ");
#nullable restore
#line 14 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\Cats\Details.cshtml"
    Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n<h6>Breed: ");
#nullable restore
#line 16 "D:\Asp.Net Core Development\FDMC_MVC\FDMC_MVC.App\Views\Cats\Details.cshtml"
      Write(Model.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FDMC_MVC.App.ViewModels.Cats.ViewModels.CatDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
