#pragma checksum "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59d43b310109b7b047c55f3842c53cfc8b47d62b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_LogOut), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/LogOut.cshtml")]
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
#line 2 "D:\Programming\Tamin-New\Areas\Identity\Pages\_ViewImports.cshtml"
using Tamin.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Tamin-New\Areas\Identity\Pages\_ViewImports.cshtml"
using Tamin.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Tamin.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml"
using Tamin.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml"
using Tamin.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/LogOut")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59d43b310109b7b047c55f3842c53cfc8b47d62b", @"/Areas/Identity/Pages/Account/LogOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93027a998a4fbe5d8f4d9fa59ce2890d2718070c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb047d97af27b17376592f99b1d9e8fc97d7494b", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_LogOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1>");
#nullable restore
#line 19 "D:\Programming\Tamin-New\Areas\Identity\Pages\Account\LogOut.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>شما از سیستم خارج شدید.</p>\r\n</header>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IDateData _dbDateData { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
