#pragma checksum "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42fe441cb1ce3ccac96e9543316c99febd5cd66f3550324b5ace47799a655c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"42fe441cb1ce3ccac96e9543316c99febd5cd66f3550324b5ace47799a655c05", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Projelerim </h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>
");
#nullable restore
#line 10 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"grid-item\">\n                <a href=\"https://dribbble.com\">\n                    <figure class=\"portfolio-item\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 599, "\"", 619, 1);
#nullable restore
#line 15 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 605, item.ImageUrl, 605, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
#nullable restore
#line 15 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                      Write(item.ImageUrl2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\n                        <figcaption>\n                            <h4 class=\"h5 mb-0\">");
#nullable restore
#line 17 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <div>");
#nullable restore
#line 18 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                            Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        </figcaption>\n                    </figure>\n                </a>\n            </div>\n");
#nullable restore
#line 23 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
