#pragma checksum "C:\Users\murat\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AdminNotificationNavbarList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7509f591c49e5c780e2f31eadaa0641cbada963aa0d144173ce57c4201c53ed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNotificationNavbarList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNotificationNavbarList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7509f591c49e5c780e2f31eadaa0641cbada963aa0d144173ce57c4201c53ed1", @"/Views/Shared/Components/AdminNotificationNavbarList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AdminNotificationNavbarList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<li class=""nav-item dropdown border-left"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
        <i class=""mdi mdi-bell""></i>
        <span class=""count bg-danger""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
        <h6 class=""p-3 mb-0"">Bildirimler</h6>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-calendar text-success""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Bugün Yapılacak</p>
                <p class=""text-muted ellipsis mb-0""> ToDoList üzerinde yapman gereken işler </p>
            </div>
        </a>
        <div class=""dropdown-divide");
            WriteLiteral(@"r""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-settings text-danger""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Ayarlar</p>
                <p class=""text-muted ellipsis mb-0""> Dashboard Güncellendi </p>
            </div>
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-link-variant text-warning""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Duyuru Detayları</p>
                <p class=""text-muted ellipsis mb-0""> Duyuru Paneline Git </p>
 ");
            WriteLiteral("           </div>\r\n        </a>\r\n        <div class=\"dropdown-divider\"></div>\r\n        <p class=\"p-3 mb-0 text-center\">Tüm bildirimleri gör</p>\r\n    </div>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
