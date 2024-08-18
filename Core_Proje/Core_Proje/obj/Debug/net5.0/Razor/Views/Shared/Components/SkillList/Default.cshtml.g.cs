#pragma checksum "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0771b2cd61c24f85372435eda22ac82099f1056aab6adef0034ddfe36d217f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0771b2cd61c24f85372435eda22ac82099f1056aab6adef0034ddfe36d217f0d", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">My Skills</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">I am a quick learner and specialize in multitude of skills required for Web Application Development and Product Design</p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                 foreach (var item in Model)
                {
                    var count = Model.Count();

                    if (count >= 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-5\">\n                            <div class=\"py-1\">\n                                <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 22 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 22 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                                  Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n                                <div class=\"progress my-1\">\n                                    <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"");
#nullable restore
#line 24 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1192, "\"", 1219, 3);
            WriteAttributeValue("", 1200, "width:", 1200, 6, true);
#nullable restore
#line 24 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1206, item.Value, 1207, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1218, "%", 1218, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1220, "\"", 1247, 1);
#nullable restore
#line 24 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1236, item.Value, 1236, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 28 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-5 offset-md-2\">\n                            <div class=\"py-1\">\n                                <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 33 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 33 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                                  Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n                                <div class=\"progress my-1\">\n                                    <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"");
#nullable restore
#line 35 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1957, "\"", 1984, 3);
            WriteAttributeValue("", 1965, "width:", 1965, 6, true);
#nullable restore
#line 35 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1971, item.Value, 1972, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1983, "%", 1983, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1985, "\"", 2012, 1);
#nullable restore
#line 35 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 2001, item.Value, 2001, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\n                                </div>\n                            </div>\n\n                        </div>\n");
#nullable restore
#line 40 "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                    }





                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
