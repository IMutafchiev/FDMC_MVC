#pragma checksum "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0bab5a04168a7e95b71def0042d7e473a525e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FDMC_RazerPages.App.Pages.Cats.Pages_Cats_Details), @"mvc.1.0.razor-page", @"/Pages/Cats/Details.cshtml")]
namespace FDMC_RazerPages.App.Pages.Cats
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
#line 1 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\_ViewImports.cshtml"
using FDMC_RazerPages.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0bab5a04168a7e95b71def0042d7e473a525e6", @"/Pages/Cats/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8bce089011d97a193d9e1023105eda36da10a07", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cats_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml"
Write(Model.Cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 136, "\"", 161, 1);
#nullable restore
#line 9 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml"
WriteAttributeValue("", 142, Model.Cat.ImageUrl, 142, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\"");
            BeginWriteAttribute("alt", " alt=\"", 174, "\"", 195, 1);
#nullable restore
#line 9 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml"
WriteAttributeValue("", 180, Model.Cat.Name, 180, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<br />\r\n\r\n<p><strong>Age: ");
#nullable restore
#line 13 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml"
           Write(Model.Cat.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<p><strong>Breed: ");
#nullable restore
#line 15 "D:\Asp.Net Core Development\FDMC_RazerPages\FDMC_RazerPages.App\Pages\Cats\Details.cshtml"
             Write(Model.Cat.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FDMC_RazerPages.App.Pages.Cats.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FDMC_RazerPages.App.Pages.Cats.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FDMC_RazerPages.App.Pages.Cats.DetailsModel>)PageContext?.ViewData;
        public FDMC_RazerPages.App.Pages.Cats.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591